import sqlite3

# Open the connection to the database.
con = sqlite3.connect("Proj/JLPT Trainer/JLPT Trainer/bin/Debug/dict_db.db")
cursor = con.cursor()

# Give a user (TestLevel4) most of the cards from JLPT Level 5
for i in range(1, 640):
    cursor.execute(
        "INSERT INTO UserCards (UserID, CardID, Stack) VALUES (6,?,2)", (i,))

# Close the connections and commit the new functions.
cursor.close()
con.commit()
con.close()
