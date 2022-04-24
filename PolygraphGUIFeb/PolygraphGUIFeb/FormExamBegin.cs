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

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Hide();
            pleaseConfirm.Hide();
            bool consentComplete = false;
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Rate = -1;
            labelWelcome1.Show();
            synthesizer.Speak("Welcome to the polygraph examination.");
            labelWelcome2.Show();
            synthesizer.Speak("You will be asked a series of Yes or No questions");
            labelWelcome3.Show();
            synthesizer.Speak("Please answer with yes or no only");
            beginExamConsent();     //begins exam's consent function

            
        }

        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show("Recognized text: " + e.Result.Text);
        }

        public void beginBaselineQuestions()
        {
            bool baselineComplete = false;
            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            Choices list = new Choices();
            list.Add(new string[] { "Yes", "No"});
            Grammar gr = new Grammar(new GrammarBuilder(list));
            recognizer.LoadGrammar(gr);
            recognizer.RequestRecognizerUpdate();
            recognizer.SetInputToDefaultAudioDevice(); 

            var synthesizer2 = new SpeechSynthesizer();
            synthesizer2.SetOutputToDefaultAudioDevice();
            synthesizer2.Rate = -1;

            //ASKING BASELINE QUESTIONS HERE - SYNCHRONIZE WITH DATA FROM SENSOR
            string nextLine = "Asked 'Is Your First Name " + subAndQuestions[1] + "?'";
            synthesizer2.Speak("Is your first name " + subAndQuestions[1]);
            lbExamEvents.Items.Add(nextLine);

            RecognitionResult resultBaseFName = recognizer.Recognize();
            do
            {
                try
                {
                    if (resultBaseFName.Text == "Yes")
                    {
                        //ANSWER IS ALWAYS CORRECT HERE - ALWAYS IS SUBJECTS CORRECT NAME
                        Task.Delay(2000);
                        string nextLine2 = "Asked 'Are you holding a baseball bat?'";
                        synthesizer2.Speak("Are you holding a baseball bat?");
                        lbExamEvents.Items.Add(nextLine2);
                        RecognitionResult resultBaseLName = recognizer.Recognize();
                        if (resultBaseLName.Text == "No")
                        {
                            //ANSWER IS ALWAYS CORRECT HERE ALSO
                            baselineComplete = true;
                            if (baselineComplete == true)
                            {
                                MessageBox.Show("End of Baseline Asessment");
                                break;
                            }
                        }
                        else if (resultBaseLName.Text == "Yes")
                        {
                            synthesizer2.Speak("Please answer the baseline question truthfully");
                            string untruthfulInner = "Subject answered objective baseline question incorrectly";
                            lbExamEvents.Items.Add(untruthfulInner);
                        }

                    }
                    else if (resultBaseFName.Text == "No")
                    {
                        synthesizer2.Speak("Please answer the baseline question truthfully");
                        string untruthfulOuter = "Subject answered objective baseline question incorrectly";
                        lbExamEvents.Items.Add(untruthfulOuter);
                        beginBaselineQuestions();

                    }
                }
                catch(Exception ex)
                {
                    synthesizer2.Speak("The question needs to be repeated");
                    beginBaselineQuestions();
                }
            }
            while (baselineComplete == false);
        }

        public void beginExamConsent()
        {
            var synthesizer1 = new SpeechSynthesizer();
            synthesizer1.SetOutputToDefaultAudioDevice();
            synthesizer1.Rate = -1;
            labelWelcome4.Show();
            synthesizer1.Speak("Do you consent to this examination?");

            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            Choices list = new Choices();
            list.Add(new string[] { "Yes", "No", "Rebecca" });
            Grammar gr = new Grammar(new GrammarBuilder(list));
            recognizer.LoadGrammar(gr);
            recognizer.RequestRecognizerUpdate();
            recognizer.SetInputToDefaultAudioDevice();
            RecognitionResult result = null;
            result = recognizer.Recognize();

            try 
            {

                if (result.Text == "Yes")
                {
                    String str = "";
                    str += "Subject has given consent";
                    lbExamEvents.Items.Add(str);

                    synthesizer1.Speak("Thank you for confirming");
                    synthesizer1.Speak("You will now be asked a series of questions. Please answer with Yes or No");
                    Task.Delay(2000);
                    beginBaselineQuestions();
                }
                else if (result.Text == "No")
                {
                    String str = "";
                    str += "Subject has not given consent";
                    lbExamEvents.Items.Add(str);

                }
            }
            catch(Exception ex)
            {
                synthesizer1.Speak("The question needs to be repeated");
                beginExamConsent();
            }
            
        }

        private void lbExamEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
