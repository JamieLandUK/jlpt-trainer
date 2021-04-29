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
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace JLPT_Trainer
{
    public partial class frmSynthTest : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        SpeechRecognitionEngine dictationsre = new SpeechRecognitionEngine();
        SpeechSynthesizer synthEN = new SpeechSynthesizer();
        SpeechSynthesizer synthJP = new SpeechSynthesizer();

        public frmSynthTest()
        {
            InitializeComponent();
            Load += new EventHandler(frmSynthTest_Load);
        }

        private void frmSynthTest_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "greet English", "greet Japanese", "example Japanese", "example English", "show installed voices" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(commands);
            Grammar grammar = new Grammar(gb);

            synthEN.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en_GB"));
            synthJP.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("ja_JP"));

            sre.LoadGrammarAsync(grammar);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += sre_SpeechRecognized;

            DictationGrammar dictation = new DictationGrammar();
            dictationsre.LoadGrammarAsync(dictation);
            dictationsre.SetInputToDefaultAudioDevice();
            dictationsre.SpeechRecognized += dictationsre_SpeechHypothesized;

        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "greet English":
                    rtbContent.Text += "\nHello Jamie!";
                    break;
                case "greet Japanese":
                    rtbContent.Text += "\nこんにちは、ジェイミー!";
                    break;
                case "example Japanese":
                    synthJP.SpeakAsync("こんにちは。よく聞こえますか。大丈夫ですか。");
                    rtbContent.Text += "\nReading example Japanese phrase.";
                    break;
                case "example English":
                    synthEN.SpeakAsync("Hello. Can you hear me? How are you?");
                    rtbContent.Text += "\nReading example English phrase.";
                    break;
                case "show installed voices":
                    installedVoiceData();
                    break;
            }
        }

        private void dictationsre_SpeechHypothesized(object sender, SpeechRecognizedEventArgs e) 
        {
            rtbContent.Text += "\n" + e.Result.Text;
        }

        private void installedVoiceData()
        {
            // Installed Voices
            rtbContent.Text += "\n---------------------";
            rtbContent.Text += "\nFinding the installed voices on the system!\n";
            foreach (InstalledVoice iv in synthEN.GetInstalledVoices())
            {
                VoiceInfo info = iv.VoiceInfo;
                string AudioFormats = "";
                foreach (SpeechAudioFormatInfo fmt in info.SupportedAudioFormats)
                {
                    AudioFormats += String.Format("{0}\n",
                    fmt.EncodingFormat.ToString());
                }

                rtbContent.Text += "\n Name:          " + info.Name;
                rtbContent.Text += "\n Culture:       " + info.Culture;
                rtbContent.Text += "\n Age:           " + info.Age;
                rtbContent.Text += "\n Gender:        " + info.Gender;
                rtbContent.Text += "\n Description:   " + info.Description;
                rtbContent.Text += "\n ID:            " + info.Id;
                rtbContent.Text += "\n Enabled:       " + iv.Enabled;

                string AdditionalInfo = "";
                foreach (string key in info.AdditionalInfo.Keys)
                {
                    AdditionalInfo += String.Format("  {0}: {1}\n", key, info.AdditionalInfo[key]);
                }

                rtbContent.Text += " Additional Info - " + AdditionalInfo;
            }

            rtbContent.Text += "\n\nSynthJP voice - " + synthJP.Voice.Name;
            rtbContent.Text += "\nSynthEN voice - " + synthEN.Voice.Name;
            rtbContent.Text += "\n---------------------\n";
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            // Enable the speech engine.
            if (btnEnable.Text == "Enable Voice Synthesis and Recognition")
            {
                sre.RecognizeAsync(RecognizeMode.Multiple);
                btnEnable.Text = "Disable Voice Synthesis and Recognition";
            }
            else if (btnEnable.Text == "Disable Voice Synthesis and Recognition")
            {
                sre.RecognizeAsyncStop();
                btnEnable.Text = "Enable Voice Synthesis and Recognition";
            }
        }

        private void btnDictation_Click(object sender, EventArgs e)
        {
            // Enable the speech engine.
            if (btnDictation.Text == "Enable Dictation")
            {
                dictationsre.RecognizeAsync(RecognizeMode.Multiple);
                btnDictation.Text = "Disable Dictation";
            }
            else if (btnDictation.Text == "Disable Dictation")
            {
                dictationsre.RecognizeAsyncStop();
                btnDictation.Text = "Enable Dictation";
            }
        }
    }
}
