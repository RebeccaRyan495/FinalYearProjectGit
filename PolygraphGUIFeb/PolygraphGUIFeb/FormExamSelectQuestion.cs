using BusinessEntities;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygraphGUIFeb
{
    public partial class FormExamSelectQuestion : Form
    {

        private IModel Model;
        public List<string> subAndQuestions;
        public List<string> questions = new List<string>();

        public FormExamSelectQuestion(IModel _Model, List<string> subAndQuestions)
        {
            InitializeComponent();
            Model = _Model;
            this.subAndQuestions = subAndQuestions;
            Model.GetAllQuestions();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamSelectSubject ss = new FormExamSelectSubject(Model);
            ss.ShowDialog();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormAddCustomQuestion(Model);
            f.ShowDialog();
            this.Close();
        }

        private void FormExamSelectQuestion_Load(object sender, EventArgs e)
        {
            listBoxQuestions.Items.Clear();
            Model.GetAllQuestions();
            btnContinue.Hide();
            btnDebug.Hide();

            foreach (IQuestion question in Model.QuestionList)              //adds all questions upon loading form
            {
                String str = "";
                str += question.AQuestion;
                listBoxQuestions.Items.Add(str);

            }
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Question q in Model.QuestionList)                  //outputs ID of question
            {
                string text = listBoxQuestions.GetItemText(listBoxQuestions.SelectedItem); //gets the text in the list box
                if (text == q.AQuestion.ToString())
                {
                    tbSubID.Text = q.QuestionID.ToString();
                }

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (Question q in Model.QuestionList)      //compares each question in Model's list to whats in listbox (populated from above) basically, does it exist?
            {
                string text = listBoxQuestions.GetItemText(listBoxQuestions.SelectedItem); //gets the text in the list box
                if (text == q.AQuestion.ToString())             //if there is a match between whats in list box and whats in Model
                {
                    questions.Add(q.QuestionID);                //model's question ID is added to Questions list
                    questions.Add(q.AQuestion);                 //model's question string is added to Questions list

                    String selectedStr = "";
                    selectedStr += q.AQuestion;
                    lbSelected.Items.Add(selectedStr);
                    listBoxQuestions.Items.Remove(q.AQuestion);     //adds and takes away questions from each box


                    //subAndQuestions.AddRange(questions);        //addRange allows for a second list to be passed into first and iterated over
                    //added question list into SubAndQuestion list to be passed to Review form

                }

            }
            btnContinue.Show();
            btnDebug.Show();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamReviewAndBegin fff = new FormExamReviewAndBegin(Model, subAndQuestions, questions);
            fff.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e) //REMOVE BUTTON
        {
            foreach (Question q in Model.QuestionList)
            {
                string text = lbSelected.GetItemText(lbSelected.SelectedItem); //gets the text in the list box
                //MessageBox.Show(text); ------DEBUGGING--------
                //MessageBox.Show("LOOPING ALL QUESTIONS  "+ q.AQuestion);
                //the fields are matching, should work, issue with list instead - fixed
                if (text == q.AQuestion.ToString())
                {
                    questions.Remove(q.QuestionID);
                    questions.Remove(q.AQuestion);

                    String selectedStr = "";
                    selectedStr += q.AQuestion;
                    lbSelected.Items.Remove(selectedStr);
                    listBoxQuestions.Items.Add(q.AQuestion);

                }

            }
            btnContinue.Hide();
        }

        private void lbSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Question q in Model.QuestionList)
            {
                string text = lbSelected.GetItemText(lbSelected.SelectedItem); //gets the text in the list box
                if (text == q.AQuestion.ToString())
                {
                    tbSubID.Text = q.QuestionID.ToString();
                }


            }
        }

        private void btnDebug_Click(object sender, EventArgs e)     //hidden in application, just testing output of each list
        {
            MessageBox.Show(questions[0]);
            MessageBox.Show(questions[1]);
            MessageBox.Show(questions[2]);
            MessageBox.Show(questions[3]);
            MessageBox.Show(questions[4]);
            MessageBox.Show(questions[5]);

            for (int i = 0; i < subAndQuestions.Count; i++)
            {
                MessageBox.Show("NOW USING SUBANDQ   " + subAndQuestions[i]);
            }

        }
    }
}
