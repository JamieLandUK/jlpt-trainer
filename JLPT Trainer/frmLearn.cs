using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Speech.Synthesis;

namespace JLPT_Trainer
{
    public partial class frmLearn : Form
    {
        SpeechSynthesizer synthJP = new SpeechSynthesizer();
        UserCards userCards = new UserCards();
        List<VocabCard> localCards = CardsGlobal.VocabCards.ToList();
        Random random = new Random();

        public frmLearn()
        {
            InitializeComponent();
            Load += new EventHandler(frmLearn_Load);
        }

        public void frmLearn_Load(object sender, EventArgs e)
        {
            tbKanji.Text = "";
            tbPronunciation.Text = "";
            tbMeanings.Text = "";

            // Load the SQLite database
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;

            // We need UserCards
            sqlite_conn = new SQLiteConnection("Data Source=dict_db.db;Version=3;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM UserCards";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                // Finding the cards that are related to the user.
                if (sqlite_datareader.GetInt32(0) == UserGlobal.UID)
                {
                    // Add that card to the list.
                    userCards.AddCard(
                        CardsGlobal.VocabCards.Find(x => x.VocabID == sqlite_datareader.GetInt32(1)), // CardID
                        sqlite_datareader.GetInt32(2) // Stack
                    );
                }
            }
            sqlite_conn.Close();

            // Set up the synthesiser
            synthJP.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("ja_JP"));

            // Find if the user should be increased to the next level or not
            // (95% of the content from a level already in their deck)
            CheckLevel();

            // Remove the already learned cards from the global version of the total Vocab cards
            // Doing it in descending order so there are no problems with indices moving.
            for (int i = localCards.Count-1; i >= 0; i--)
            {
                // Get the card from the list
                VocabCard card = localCards[i];

                // If the user has already learned that card...
                if (userCards.LearnedCards.Contains(card))
                    // Take it out of the local list
                    localCards.Remove(card);

                // If that card is above the level that the user is working at...
                // If the user is JLPT level 4, then they can access both level 4 and level 5 cards.
                if (card.JLPTLevel < UserGlobal.Level)
                    // Take it out of the local list
                    localCards.Remove(card);
            }

            // Generate the next card for the user to learn
            VocabCard randCard = GenerateCard();

            // The card is suitable for the user
            DisplayCard(randCard);

        }

        private void btnAloud_Click(object sender, EventArgs e)
        {
            // If the user clicks this, use SpeechSynthesis to read the vocabulary
            synthJP.SpeakAsync(tbPronunciation.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            VocabCard card = localCards.Find(x => x.Kanji == tbKanji.Text);

            // Erase the old text
            tbKanji.Text = "";
            tbPronunciation.Text = "";
            tbMeanings.Text = "";

            // Check if the user's at the right level
            CheckLevel();
            // Save the shown card.
            SaveCard(card);
            // Make the next one.
            card = GenerateCard();
            // Show it.
            DisplayCard(card);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            VocabCard card = localCards.Find(x => x.Kanji == tbKanji.Text);

            // Send to SaveCard with the card that is currently shown.
            SaveCard(card);

            // Close the screen
            this.Hide();
        }

        private VocabCard GenerateCard()
        {
            // Find a card that they haven't already learned randomly and display that
            VocabCard card;
            // Get a random card from the treated local list.
            card = localCards[random.Next(localCards.Count)];
            return card;
        }

        private void SaveCard(VocabCard card)
        {
            // Open SQLite database and INSERT the new card under the userID in stack 1.
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;

            sqlite_conn = new SQLiteConnection("Data Source=dict_db.db;Version=3;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO UserCards (UserID, CardID, Stack) VALUES ({UserGlobal.UID}, {card.VocabID}, 1);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();

            // Also add the item to userCards here so that we don't need to update it through a query.
            userCards.AddCard(card, 1);

            // Remove the card from localCards.
            localCards.Remove(card);
        }

        private void DisplayCard(VocabCard card)
        {
            // Change each of the boxes to display the new card to the user.
            tbKanji.Text = card.Kanji;
            tbPronunciation.Text = card.Reading;
            tbMeanings.Text = string.Join(", ", card.Definitions);
        }

        private void CheckLevel()
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            int count_known = 0; // The cards from that level that the user knows
            int count_total = 0; // The total number of cards from that level
            foreach (VocabCard card in CardsGlobal.VocabCards)
            {
                // Finding the user's cards
                if (card.JLPTLevel == UserGlobal.Level)
                {
                    count_total++;
                    // If the user has already learned that card, count it under known.
                    if (userCards.LearnedCards.Contains(card))
                        count_known++;
                }
            }

            // If the user is JLPT Level 3, the total will be 0.
            if (count_total != 0)
            {
                // If the user has done 90% of their level...
                if (count_known / count_total >= 0.90)
                {
                    // Update UserGlobal.Level
                    // (With this, it should be possible to reach level 3)
                    UserGlobal.Level--;

                    // UPDATE the database too
                    sqlite_conn = new SQLiteConnection("Data Source=dict_db.db;Version=3;");
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = $"UPDATE Users SET LearningLevel = {UserGlobal.Level} WHERE UserID = {UserGlobal.UID}";
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_conn.Close();
                }
            }
        }
    }
}
