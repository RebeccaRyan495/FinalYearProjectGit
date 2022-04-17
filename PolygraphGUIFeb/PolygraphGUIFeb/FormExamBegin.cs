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
using ModelLayer;

namespace PolygraphGUIFeb
{
    public partial class FormExamBegin : Form
    {
        private List<string> subAndQuestions;
        private List<string> questions;
        private List<string> baselineQuestions;

        private IModel Model;
        public FormExamBegin(IModel _Model, List<string> subAndQuestions, List<string> questions)
        {
            InitializeComponent();
            Model = _Model;
            this.subAndQuestions = subAndQuestions;
            this.questions = questions;

        }

        private void FormExamBegin_Load(object sender, EventArgs e)
        {
            btnConfirm.Show();
            labelWelcome1.Hide();
            labelWelcome2.Hide();
            labelWelcome3.Hide();
            labelWelcome4.Hide();
           // baselineQuestions.Add()
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool consentGiven = false;
            btnConfirm.Hide();
            pleaseConfirm.Hide();

            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Rate = -1;
            labelWelcome1.Show();
            synthesizer.Speak("Welcome to the polygraph examination.");
            labelWelcome2.Show();
            synthesizer.Speak("You will be asked a series of Yes or No questions");
            labelWelcome3.Show();
            synthesizer.Speak("Please answer with yes or no only");
            labelWelcome4.Show();
            synthesizer.Speak("Do you consent to this examination?");

            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            Choices list = new Choices();
            list.Add(new string[] { "Yes", "No", "Rebecca"});
            Grammar gr = new Grammar(new GrammarBuilder(list));
            recognizer.LoadGrammar(gr);
           
                try
                {
                    recognizer.RequestRecognizerUpdate();
                    recognizer.SetInputToDefaultAudioDevice();

                    RecognitionResult result = recognizer.Recognize();
                    if (result.Text == "Yes")
                    {
                        String str = "";
                        str += "Subject has given consent";
                        lbExamEvents.Items.Add(str);
                        synthesizer.Speak("Thank you for confirming");
                        synthesizer.Speak("You will now be asked a series of questions. Please answer with Yes or No");
                        consentGiven = true;
                        
                    }
                    else if (result.Text == "No")
                    {
                        String str = "";
                        str += "Subject has not given consent";
                        lbExamEvents.Items.Add(str);
                        
                    }
                    else
                    {
                        throw new Exception("An error was found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show("Recognized text: " + e.Result.Text);
        }
    }
}
