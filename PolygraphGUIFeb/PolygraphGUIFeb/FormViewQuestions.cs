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
    public partial class FormViewQuestions : Form
    {
        private IModel Model;
 
        public FormViewQuestions(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormViewQuestions_Load(object sender, EventArgs e)
        {
            listBoxQuestions.Items.Clear();
            Model.GetAllQuestions();

            foreach (IQuestion question in Model.QuestionList)
            {
                String str = "";
                str += question.AQuestion;
                listBoxQuestions.Items.Add(str);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu f = new FormMainMenu(Model);
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCustomQuestion f = new FormAddCustomQuestion(Model);
            f.ShowDialog();
            this.Close();
        }
    }
}
