import json
import sqlite3
import requests
import csv
import ast

# Connection string to access the dictionary database
con = sqlite3.connect("Proj/JLPT Trainer/JLPT Trainer/bin/Debug/dict_db.db")
# We want to get the names of all tables in the database...
cursor = con.execute("SELECT name FROM sqlite_master WHERE type='table';")
# And we print gather each one into a list.
tables = [
    v[0] for v in cursor.fetchall()
    if v[0] != 'sqlite_sequence'
]
# Close the cursor when you are done executing lines.
cursor.close()

# For each table in the list, print all headers.
print(tables)
for table in tables:
    cursor = con.execute(f"SELECT * FROM {table}")
    print(table, [i[0] for i in cursor.description])
cursor.close()

# Print all of the users in the list to test the connections.
cursor = con.execute("SELECT UserID, Name, LearningLevel FROM Users")
print("UserID | Name | Learning Level")
for row in cursor:
    print(row)
cursor.close()

# Access the N5 .csv created in vocabtocsv.py
print("\nN5 .csv")
# Empty list to fill when the file is opened.
n5list = []
# Open the file (as utf8 for the JPN text)...
with open('n5vocab.csv', encoding='utf8') as n5:
    # Use a csv reader with the right delimiter
    reader = csv.reader(n5, delimiter=',')
    i = 0
    for row in reader:
        # Skip the first row (the headers)
        if i == 0:
            i += 1
            continue
        else:
            # Append the full content into the empty list above.
            n5list.append([row[0], row[1], row[2], ast.literal_eval(row[3])])
# Report the N5 list has been used fully.
print("N5 list done")

# Same as the N5 programming above.
print("\nN4 .csv")
n4list = []
with open('n4vocab.csv', encoding='utf8') as n4:
    reader = csv.reader(n4, delimiter=',')
    i = 0
    for row in reader:
        if i == 0:
            i += 1
            continue
        else:
            n4list.append([row[0], row[1], row[2], ast.literal_eval(row[3])])
# Report the N4 list has been used fully.
print("N4 list done")

# This is in reference to the JLPT level of the vocabulary.
difficulty_level = 5
# Our outputs (both N5 and N4 content)
listoutput = []
# Loops through both the N5 List and the N4 list.
for content in [n5list, n4list]:
    print("------------------")
    print("Nx level start")
    # For each line of the content (item)
    for item in content:
        # HTTP request for the website in the content.
        req = requests.get(item[2])
        # Output takes the json output from the request and turns it into a list.
        output = json.loads(req.text)
        # X is the count for the various lines of definitions
        countx = 0
        # Y is the count for the definitions within the line of definitions
        county = 0
        # List to hold the cleaned definitions
        # By default, holds the items that were in the original list.
        definitions = item[3]
        # ["data"][0]["senses"] accesses the definitions portion of the json.
        for line in output["data"][0]["senses"]:
            # get first 3 lines if available
            if countx in [0, 1, 2]:
                # ["english_definitions"] is an array of definitions.
                # Take each definition from these to treat them.
                for defi in line["english_definitions"]:
                    # Treat the strings
                    # We only want the first few definitions so that there aren't too many for the final GUI to handle.
                    if county in [0, 1, 2, 3]:
                        # ") " is to defend against any strings from the website which are formatted like:
                        # To drive (a car) quickly.
                        # In this case, we don't want to handle these as they are too much hassle.
                        if ") " in defi:
                            # Skip this line
                            next
                        # Next up, having a bracket in general we want to remove.
                        # To drive (a car).
                        # This is easier to fix but we need to keep this content out otherwise it will
                        # be difficult to check the definitions against the user answer in the program.
                        elif "(" in defi:
                            # Deleting up to the bracket if that is the full content.
                            x = defi.find("(")
                            # Substring the first portion of the text until the found bracket value, minus 1, to remove the space.
                            defi = defi[0:x-1]
                        # If there are too many spaces in the definition (too many words), skip it.
                        elif defi.count(" ") > 3:
                            next
                        # Finally, .casefold() so we can check the definitions in a case-insensitive way.
                        if defi.casefold() not in definitions:
                            # If the definition isn't already in the list, append it.
                            definitions.append(defi)
                    county += 1
            countx += 1
        # Output as: Kanji, Reading, JLPT Level, definitions
        listoutput.append([item[0], item[1], difficulty_level, definitions])
    # Going from N5 to N4
    difficulty_level -= 1
    print("Nx level end")
print(listoutput)

# Writing this content to the database.
cursor = con.cursor()
for item in listoutput:
    # Cards = CardID | Kanji | Reading | Level
    # First input our lines into the Cards table.
    cursor.execute("INSERT INTO Cards (Kanji, Reading, Level) VALUES (?,?,?)",
                   (item[0], item[1], item[2],))
    # For each line, pull the ID for that Kanji from the table (Kanji is unique)
    cursor.execute(
        f"SELECT CardID FROM Cards WHERE Kanji='{item[0]}';")
    card_id = cursor.fetchone()
    # Loop through each definition in the item and Insert into CardMeanings based on the CardID found.
    # CardMeanings = MeaningID | CardID | Meaning
    for definition in item[3]:
        cursor.execute(
            "INSERT INTO CardMeanings (CardID, Meaning) VALUES (?,?)", (card_id[0], definition,))
print("Dictionary database updated with new cards")
# UserCards = UserID | CardID | Stack
# TestUser1 = UserID 4
cursor.execute(
    "INSERT INTO UserCards (UserID, CardID, Stack) VALUES (4, 10, 1);")
cursor.execute(
    "INSERT INTO UserCards (UserID, CardID, Stack) VALUES (4, 20, 1);")
cursor.execute(
    "INSERT INTO UserCards (UserID, CardID, Stack) VALUES (4, 30, 1);")
cursor.close()
# For testing, add three cards to the TestUser1's UserCards
print("UserCards testing data inserted")
con.commit()
con.close()
print("Connection closed.")
