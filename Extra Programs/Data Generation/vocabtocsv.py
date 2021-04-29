import re
import csv
from alphabet_detector import AlphabetDetector
ad = AlphabetDetector()


def splitter(line):
    out = []
    split = line.split(' ', 2)
    if (ad.only_alphabet_chars(split[1], "LATIN")):
        # Vocabulary entry without reading
        split = line.split(' ', 1)
        kanji = split[0]
        reading = split[0]
        meanings_temp = split[1].strip()
    else:
        # Vocabulary entry with both a reading and kanji
        kanji = split[0]
        reading = split[1]
        meanings_temp = split[2].strip()
    meanings_temp2 = re.split('[,]{1}', meanings_temp)
    meanings = []
    for meaning in meanings_temp2:
        meanings.append(meaning.lstrip())

    api = "https://jisho.org/api/v1/search/words?keyword=" + kanji

    out.append(kanji)
    out.append(reading)
    out.append(api)
    out.append(meanings)
    return out


fsn5 = open('n5.txt', 'r', encoding='utf-8').readlines()
fsn4 = open('n4.txt', 'r', encoding='utf-8').readlines()
n5vocab = []
n4vocab = []

for row in fsn5:
    n5vocab.append(splitter(row))
with open("n5vocab.csv", "w", encoding='utf-8', newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["Kanji", "Reading", "API Call", "Meanings"])
    writer.writerows(n5vocab)

for row in fsn4:
    n4vocab.append(splitter(row))
with open("n4vocab.csv", "w", encoding='utf-8', newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["Kanji", "Reading", "API Call", "Meanings"])
    writer.writerows(n4vocab)
