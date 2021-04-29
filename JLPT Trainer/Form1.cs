using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Data.SQLite;

namespace JLPT_Trainer
{
    public partial class windowMain : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();

        public windowMain()
        {
            InitializeComponent();
            Load += new EventHandler(windowMain_Load);
        }

        private void windowMain_Load(object sender, EventArgs e)
        {
            // Voice commands
            Choices commands = new Choices();
            commands.Add(new string[] { "learn", "review", "cards" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(commands);
            Grammar grammar = new Grammar(gb);

            sre.LoadGrammarAsync(grammar);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += sre_SpeechRecognized;

            // Loading Cards into a list to be handed to each screen that needs it.
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;

            sqlite_conn = new SQLiteConnection("Data Source=dict_db.db;Version=3;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Cards";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            List<VocabCard> temp = new List<VocabCard>();
            while (sqlite_datareader.Read())
            {
                // VocabCards objects
                temp.Add(new VocabCard(
                    sqlite_datareader.GetInt32(0), // VocabID
                    sqlite_datareader.GetString(1), // Kanji
                    sqlite_datareader.GetString(2), // Reading
                    sqlite_datareader.GetInt32(3) // JLPT Level
                ));
            }
            sqlite_datareader.Close();

            CardsGlobal.VocabCards = temp;

            // Getting the definitions.
            sqlite_cmd.CommandText = "SELECT * FROM CardMeanings";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                foreach (VocabCard card in CardsGlobal.VocabCards)
                {
                    if (card.VocabID == sqlite_datareader.GetInt32(1)) // CardID
                    {
                        if (!card.Definitions.Contains(sqlite_datareader.GetString(2).ToLower())) // Meaning
                        {
                            card.AddDefinition(sqlite_datareader.GetString(2).ToLower());
                        }
                    }
                }
            }

            sqlite_conn.Close();
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "learn":
                    btnLearn_Click(sender, e);
                    break;
                case "review":
                    btnReviews_Click(sender, e);
                    break;
                case "cards":
                    btnCards_Click(sender, e);
                    break;
            }
        }


        private void tslTest_Click(object sender, EventArgs e)
        {
            var synthtest = new frmSynthTest();
            synthtest.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var signin = new frmSignIn();
            signin.Show();
            btnSignIn.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // The user has logged in
            if (UserGlobal.UID != 0)
            {
                lblNameWelcome.Text = "Hello, " + UserGlobal.Name + "!";
                lblNameWelcome.Visible = true;
                btnSpeechEnable.Enabled = true;
            }
        }

        private void btnSpeechEnable_Click(object sender, EventArgs e)
        {
            // Enable the speech engine.
            if (btnSpeechEnable.Text == "Enable Microphone")
            {
                sre.RecognizeAsync(RecognizeMode.Multiple);
                btnSpeechEnable.Text = "Disable Microphone";
                btnLearn.Enabled = true;
                btnCards.Enabled = true;
                btnReviews.Enabled = true;
                lblLearn.Visible = true;
                lblCards.Visible = true;
                lblReviews.Visible = true;
            }
            else if (btnSpeechEnable.Text == "Disable Microphone")
            {
                sre.RecognizeAsyncStop();
                btnSpeechEnable.Text = "Enable Microphone";
                btnLearn.Enabled = false;
                btnCards.Enabled = false;
                btnReviews.Enabled = false;
                lblLearn.Visible = false;
                lblCards.Visible = false;
                lblReviews.Visible = false;
            }
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            btnSpeechEnable_Click(sender, e);
            var learn = new frmLearn();
            learn.Show();
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            btnSpeechEnable_Click(sender, e);
            var cardcheck = new frmCheck();
            cardcheck.Show();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            btnSpeechEnable_Click(sender, e);
            var review = new frmReview();
            review.Show();
        }
    }
}
