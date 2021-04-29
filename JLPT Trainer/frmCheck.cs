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

namespace JLPT_Trainer
{
    public partial class frmCheck : Form
    {
        UserCards userCards = new UserCards();

        public frmCheck()
        {
            InitializeComponent();
            Load += new EventHandler(frmCheck_Load);
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
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
            
            while(sqlite_datareader.Read())
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

            btnUserCards_Click(sender, e);
        }

        private void btnUserCards_Click(object sender, EventArgs e)
        {
            // Clearing all items on the page.
            tbVocabItem.Text = "";
            tbReading.Text = "";
            tbMeanings.Text = "";
            cbN5.Checked = false;
            cbN4.Checked = false;
            lbCards.Items.Clear();

            // If the user hasn't learned any cards yet...
            if (!userCards.LearnedCards.Any())
            {
                // Show the information to go learn cards.
                lblAnyCards.Visible = true;
                lbCards.Enabled = false;
            }
            else
            {
                lblAnyCards.Visible = false;
                lbCards.Enabled = true;
                foreach (VocabCard card in userCards.LearnedCards)
                {
                    lbCards.Items.Add(card.Kanji);
                }
            }
        }

        private void btnAllCards_Click(object sender, EventArgs e)
        {
            lblAnyCards.Visible = false;
            lbCards.Enabled = true;

            // Resetting all controls on the page.
            tbVocabItem.Text = "";
            tbReading.Text = "";
            tbMeanings.Text = "";
            cbN5.Checked = false;
            cbN4.Checked = false;
            lbCards.Items.Clear();

            foreach (VocabCard card in CardsGlobal.VocabCards)
            {
                lbCards.Items.Add(card.Kanji);
            }
        }

        private void lbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find the vocab from the global list which has the same kanji as the selected string.
            VocabCard selected = CardsGlobal.VocabCards.Find(x => x.Kanji == lbCards.SelectedItem.ToString());
            // Write the new text to the boxes so that the user can read it
            tbVocabItem.Text = selected.Kanji;
            tbReading.Text = selected.Reading;
            string meanings = string.Join(", ", selected.Definitions);
            tbMeanings.Text = meanings;
            // Change the check boxes based on which level it is in.
            if (selected.JLPTLevel == 5)
            {
                cbN5.Checked = true;
                cbN4.Checked = false;
            }
            else if (selected.JLPTLevel == 4)
            {
                cbN5.Checked = false;
                cbN4.Checked = true;
            }

        }
    }
}
