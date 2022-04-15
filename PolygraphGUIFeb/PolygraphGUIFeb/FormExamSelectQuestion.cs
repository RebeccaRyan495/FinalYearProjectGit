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

            foreach (IQuestion question in Model.QuestionList)
            {
                String str = "";
                str += question.AQuestion;
                listBoxQuestions.Items.Add(str);

            }
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Question q in Model.QuestionList)
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
            foreach (Question q in Model.QuestionList)
            {
                string text = listBoxQuestions.GetItemText(listBoxQuestions.SelectedItem); //gets the text in the list box
                //MessageBox.Show(text); ------DEBUGGING--------
                //MessageBox.Show("LOOPING ALL QUESTIONS  "+ q.AQuestion);
                //the fields are matching, should work, issue with list instead
                if (text == q.AQuestion.ToString())
                {
                    questions.Add(q.QuestionID);
                    questions.Add(q.AQuestion);

                    String selectedStr = "";
                    selectedStr += q.AQuestion;
                    lbSelected.Items.Add(selectedStr);
                    listBoxQuestions.Items.Remove(q.AQuestion);
                    subAndQuestions.Add(questions.ToString());
                    //added question list into SubAndQuestion list to be passed to Review form

                }

            }
            btnContinue.Show();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamReviewAndBegin fff = new FormExamReviewAndBegin(Model, subAndQuestions);
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
                //the fields are matching, should work, issue with list instead
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
    }
}
