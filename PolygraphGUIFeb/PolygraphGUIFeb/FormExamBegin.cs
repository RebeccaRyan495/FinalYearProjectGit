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
        private IModel Model;
        public FormExamBegin(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;

        }

        private void FormExamBegin_Load(object sender, EventArgs e)
        {
            btnConfirm.Show();
            examCountInfo.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Hide();
            pleaseConfirm.Hide();
            examCountInfo.Show();
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Rate = -1;
            synthesizer.Speak("Welcome to the polygraph application. You will be asked a series of Yes or No questions");
            synthesizer.Speak("Please answer with yes or no only. Do you consent to this examination?");

            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            GrammarBuilder Yes = new GrammarBuilder("Yes");
            Grammar grammarLib = new Grammar(Yes);
            recognizer.LoadGrammar(grammarLib);
            recognizer.SetInputToDefaultAudioDevice();
            //recognizer.SpeechRecognized +=
            //new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
            RecognitionResult result = recognizer.Recognize();
            if(result.Text == "Yes")
            {
                MessageBox.Show("Subject has given consent");
            }
            else
            {
                MessageBox.Show("Consent not given");
            }
           // MessageBox.Show(result.Text);

            

        }

        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show("Recognized text: " + e.Result.Text);
        }
    }
}
