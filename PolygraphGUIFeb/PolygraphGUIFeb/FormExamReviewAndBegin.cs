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
    public partial class FormExamReviewAndBegin : Form
    {
        private IModel Model;
        private List<string> subAndQuestions;
        private List<string> questions;


        //public FormExamReviewAndBegin(ModelLayer.IModel model)
        //{
        //    InitializeComponent();
        //}

        public FormExamReviewAndBegin(IModel _Model, List<string> subAndQuestions, List<string> questions)
        {

            InitializeComponent();
            Model = _Model;
            this.subAndQuestions = subAndQuestions;
            this.questions = questions;
            Model.GetAllQuestions();

        }


        private void testShowList_Click(object sender, EventArgs e)
        {

        }

        private void FormExamReviewAndBegin_Load(object sender, EventArgs e)
        {
            btnDebug.Hide();
            subID.Text = subAndQuestions[0];
            subFirstName.Text = subAndQuestions[1];
            subLastName.Text = subAndQuestions[2];

            for (int i = 1; i < questions.Count; i+=2)
            {
                String str = "";
                str += questions[i];
                lbSelectedQs.Items.Add(str);
            }

        }

        private void lbSelectedQs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamBegin feb = new FormExamBegin(Model, subAndQuestions, questions);
            feb.ShowDialog();
            this.Close();

        }

        private void btnDebug_Click(object sender, EventArgs e)         //hidden in application, testing output of list
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
