using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Data.SQLite;
using System.Timers;

namespace JLPT_Trainer
{
    public partial class frmReview : Form
    {
        SpeechSynthesizer synthJP = new SpeechSynthesizer();
        SpeechSynthesizer synthEN = new SpeechSynthesizer();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        UserCards userCards = new UserCards();
        List<VocabCard> priorityQueue = new List<VocabCard>();
        VocabCard currentCard;
        Random random = new Random();
        System.Timers.Timer timer = new System.Timers.Timer();

        public frmReview()
        {
            InitializeComponent();
        }

        private void frmReview_Load(object sender, EventArgs e)
        {
            // Setting the synthesiser voices to the correct languages.
            synthJP.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("ja_JP"));
            synthEN.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en_GB"));
            synthJP.SetOutputToDefaultAudioDevice();
            synthEN.SetOutputToDefaultAudioDevice();

            // Recognise speech instead of hypothesise speech.
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

            // Tell the user some quick instructions on what to expect.
            synthEN.SpeakAsync("When you begin the reviews, you will hear something in Japanese. Respond with the translation in English within 5 seconds.");

            // We need UserCards
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;

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

            // Set up the timer
            timer.Elapsed += new ElapsedEventHandler(timerElapsed);
            timer.Interval = 5000; // 5000ms = 5s

            // If UserCards is empty...
            if (!userCards.LearnedCards.Any())
            {
                // They cannot enable the mic, and they cannot start the reviews.
                btnMicEnable.Enabled = false;
                tbReviews.Text = "You don't have any cards to review, learn some first!";
            }
            else
            {
                btnMicEnable.Enabled = true;
                tbReviews.Text = "You have " + userCards.LearnedCards.Count + " card(s) to review!";
            }

            // Shuffle the userCards list using Fisher-Yates shuffle
            List<VocabCard> randomised = Shuffle(userCards.LearnedCards);

            // Sort the randomised list only by the stacks
            // This produces a naive version of a priority queue.
            priorityQueue = randomised.OrderBy(o => o.Stack).ToList();

        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // This updates in real time with each word a person says.
            // We can scroll through the list to find if the spoken phrases match any definitions (hopefully).

            foreach (string def in currentCard.Definitions)
            {
                // If the spoken words contain a substring of the definitions.
                if (e.Result.Text.Contains(def.ToLower()))
                {
                    // The user said one of the correct answers
                    timer.Stop(); // So that the user doesn't get locked out, even though they got it right.
                    sre.RecognizeAsyncStop(); // We don't want the user to keep speaking and for it to be recognised.
                    AddResult(currentCard.Kanji, true);
                    SaveAnswer(currentCard, true);
                    tbRemaining.Text = priorityQueue.Count.ToString();
                    // If there are no more cards left...
                    
                    if (priorityQueue.Count == 0)
                    {
                        // Trigger the end button.
                        btnEnd_Click(sender, e);
                    }
                    else
                    {
                        FetchCard(); // Get the next card from the list.
                    }
                }
            }
        }
        private void timerElapsed(object sender, ElapsedEventArgs e)
        {
            // The user ran out of time.
            sre.RecognizeAsyncStop(); // The user can't try and get the answer after the timer is up.
            AddResult(currentCard.Kanji, false);
            SaveAnswer(currentCard, false);
            if (tbRemaining.InvokeRequired)
            {
                tbRemaining.Invoke(new MethodInvoker(delegate { tbRemaining.Text = priorityQueue.Count.ToString(); }));
            }
            else
            {
                tbRemaining.Text = priorityQueue.Count.ToString();
            }
            
            // If there are no more cards left...
            if (priorityQueue.Count == 0)
            {
                // Trigger the end button.
                btnEnd_Click(sender, e);
            }
            else 
            {
                FetchCard(); // Get the next card from the list.
            }
        }

        private void SaveAnswer(VocabCard Card, bool Correct)
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;

            sqlite_conn = new SQLiteConnection("Data Source=dict_db.db;Version=3;");
            sqlite_conn.Open();

            // When a user answers a question, INSERT INTO Reviews table:
            // ReviewID | UserID | CardID | DateTime | Correct
            var time = DateTime.Now;
            string formatted = time.ToString("yyyy-MM-dd HH:mm:ss");
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO Reviews (UserID, CardID, DateTime, Correct) VALUES ({UserGlobal.UID}, {Card.VocabID}, '{formatted}', {(Correct == true ? 1 : 0)})";
            sqlite_cmd.ExecuteNonQuery();

            // UPDATE the stack in UserCards and remove the card from UserCards so that the next random can't pick the same item:
            // UserID | CardID | Stack
            sqlite_cmd = sqlite_conn.CreateCommand();
            // We need to see what stack we update this card to be for the user.
            int new_stack = Card.Stack;
            // If they got the answer right...
            if (Correct)
            {
                // And the card isn't already at max...
                if (new_stack != 5)
                    // Increase it.
                    new_stack++;
            }
            // If they got the answer wrong...
            else
            {
                // And the card isn't already at min...
                if (new_stack != 1)
                    // Decrease it.
                    new_stack--;
            }
            sqlite_cmd.CommandText = $"UPDATE UserCards SET Stack = {new_stack} WHERE CardID = {Card.VocabID}";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // Find out if we should tell the user that they're done.
            if (!priorityQueue.Any())
            {
                synthEN.SpeakAsync("You have no more cards left to review!");
            }
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate 
                {
                    timer.Close();
                    sre.RecognizeAsyncStop();
                    this.Hide(); 
                }));
            }
            else
            {
                // Halt the timer from working.
                timer.Close();
                // Stop the voice recognition.
                sre.RecognizeAsyncStop();
                // Hide the window.
                this.Hide();
            }
        }

        private void btnMicEnable_Click(object sender, EventArgs e)
        {
            // If the user enables the mic, they can start the reviews.
            if (btnMicEnable.Text == "Enable Microphone")
            {
                btnStart.Enabled = true;
                btnMicEnable.Text = "Disable Microphone";
            }
            // If it's disabled, they can't.
            else if (btnMicEnable.Text == "Disable Microphone")
            {
                btnStart.Enabled = false;
                btnMicEnable.Text = "Enable Microphone";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Show the review content.
            tlpMain.Visible = false;
            tlpReviews.Visible = true;
            lbLastItems.Items.Clear();
            tbRemaining.Text = priorityQueue.Count.ToString();
            // Fetch our first card.
            FetchCard();
        }

        private List<VocabCard> Shuffle(List<VocabCard> vocabCards)
        {
            // https://en.wikipedia.org/wiki/Fisher–Yates_shuffle#The_modern_algorithm
            // What we use to iterate through the list to shuffle it.
            int n = vocabCards.Count;

            // Until we run out of list items...
            while (n > 1)
            {
                n--;
                int rand = random.Next(n + 1);

                // Swap based on the random number
                VocabCard value = vocabCards[rand];
                vocabCards[rand] = vocabCards[n];
                vocabCards[n] = value;
            }

            return vocabCards;
        }

        private void FetchCard()
        {
            // Sets the card to the global.
            currentCard = priorityQueue[0];
            // 'Pops' the item.
            priorityQueue.RemoveAt(0);
            // Read out the pronunciation.
            synthJP.Speak(currentCard.Reading);
            // Start the timer
            timer.Start();

            Choices choices = new Choices();
            choices.Add(currentCard.Definitions.ToArray());
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(choices);
            Grammar grammar = new Grammar(grammarBuilder);
            sre.LoadGrammarAsync(grammar);
            // Enable mic in multiple mode
            sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void AddResult(string Kanji, bool Correct)
        {
            if (lbLastItems.InvokeRequired)
            {
                lbLastItems.Invoke(new Action<string, bool>(AddResult), Kanji, Correct);
            }
            else
            {
                // Add the user's result.
                if (Correct)
                {
                    lbLastItems.Items.Add("〇 " + Kanji);
                }
                else
                {
                    lbLastItems.Items.Add("× " + Kanji);
                }
            }
            
        }
    }
}
