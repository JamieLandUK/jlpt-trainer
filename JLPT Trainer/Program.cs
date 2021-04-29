using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLPT_Trainer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new windowMain());
        }
    }

    /// <summary>
    /// VocabCard is an object to contain the cards taken from the database.
    /// VocabID is the ID of the object from the database.
    /// Kanji is the main Kanji (or the standard written word) of the vocabulary.
    /// Reading is how the Kanji above is read.
    /// JLPTLevel is the testing level that the vocabulary is included in.
    /// Definitions is a list of meanings for the vocabulary which is looped through during testing.
    /// Stack is the current User's SRS knowledge level for the vocabulary.
    /// </summary>
    class VocabCard
    {
        private int _vocab_id;
        private string _kanji;
        private string _reading;
        private int _jlpt_level;
        private List<string> _definitions;
        private int _stack;

        public VocabCard(int VocabID, string Kanji, string Reading, int JLPT_Level)
        {
            _vocab_id = VocabID;
            _kanji = Kanji;
            _reading = Reading;
            _jlpt_level = JLPT_Level;
            _definitions = new List<string>();
            _stack = 0; // default digit
            // Stack 0 = unknown
            // Stack 1 = just learned
            // ...
            // Stack 5 = mastered
        }

        public int VocabID
        {
            get { return _vocab_id; }
        }

        public string Kanji
        {
            get { return _kanji; }
        }

        public string Reading
        {
            get { return _reading; }
        }

        public int JLPTLevel
        {
            get { return _jlpt_level; }
        }

        public void AddDefinition(string Definition)
        {
            _definitions.Add(Definition);
        }

        public List<string> Definitions
        {
            get { return _definitions; }
        }

        public int Stack
        {
            get { return _stack; }
            set { _stack = value; }
        }
    }

    /// <summary>
    /// UserCards contains the learned cards of the user.
    /// LearnedCards are the cards that the user has learned (according to the database and added through the program.)
    /// AddCard is used to add a new card and requires the Card and the starting stack of the item (generally 1).
    /// </summary>
    class UserCards
    {
        private List<VocabCard> _learned_cards = new List<VocabCard>();

        public void AddCard(VocabCard Card, int Stack)
        {
            //if (Card != null)
            //{
            Card.Stack = Stack;
            _learned_cards.Add(Card);
            //}
        }

        public List<VocabCard> LearnedCards
        {
            get { return _learned_cards; }
            set { _learned_cards = value; }
        }
    }
    
    /// <summary>
    /// UserGlobal contains data about the user currently using the application.
    /// UID is the UserID
    /// Name is the name of the user.
    /// Level is the JLPT Level of the user.
    /// </summary>
    static class UserGlobal
    {
        private static int _uid = 0;
        private static string _name = "";
        private static int _level = 5;

        public static int UID
        {
            get { return _uid; }
            set { _uid = value; }
        }

        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static int Level
        {
            get { return _level; }
            set { _level = value; }
        }
    }

    /// <summary>
    /// CardsGlobal contains all vocabulary cards.
    /// This is read from the database and is used across the program.
    /// VocabCards is the list of vocabulary cards.
    /// </summary>
    static class CardsGlobal
    {
        private static List<VocabCard> _vocab_cards = new List<VocabCard>();

        public static List<VocabCard> VocabCards
        {
            get { return _vocab_cards; }
            set { _vocab_cards = value; }
        }
    }
}
