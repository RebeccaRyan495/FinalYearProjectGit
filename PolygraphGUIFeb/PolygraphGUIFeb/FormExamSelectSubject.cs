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
    public partial class FormExamSelectSubject : Form
    {
        List<string> subAndQuestions = new List<string>();
        private IModel Model;
        public FormExamSelectSubject(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuration c = new Configuration(Model);
            c.ShowDialog();
            this.Close();

        }

        private void FormExamSelectSubject_Load(object sender, EventArgs e)
        {
            Model.GetAllSubjects();
            btnSelectSub.Enabled = false;
            labelSelect.Show();
            labelSelected.Hide();
            btnClearSelection.Hide();
            btnContinue.Enabled = false;
            subAndQuestions.Clear();


            foreach (ISubject subject in Model.SubjectList)
            {
                string str = subject.SubjectFirstName;
                listBoxSubjects.Items.Add(str);

            }
        }

        private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Subject sub in Model.SubjectList)
            {
                string text = listBoxSubjects.GetItemText(listBoxSubjects.SelectedItem); //gets the text in the list box
                if (text == sub.SubjectFirstName.ToString())
                {
                    tbSubID.Text = sub.SubjectID;
                    tbFirstName.Text = sub.SubjectFirstName;
                    tbLastName.Text = sub.SubjectLastName;
                    //tbIncar.Text = sub.Incarceration.ToString();
                    string incar = sub.Incarceration.ToString();
                    if (incar.Equals("0"))
                    {
                        tbIncar.Text = "No";
                    }
                    else if (incar.Equals("1"))
                    {
                        tbIncar.Text = "Yes";
                    }
                    tbPrevTest.Text = sub.PreviousTests.ToString();
                    tbSubAdd.Text = sub.SubjectAddress;
                    tbCustName.Text = sub.CustodianName;
                    btnSelectSub.Enabled = true;

                   

                }


            }
        }

        private void btnSelectSub_Click(object sender, EventArgs e)
        {
            foreach (Subject sub in Model.SubjectList)
            {
                string text = listBoxSubjects.GetItemText(listBoxSubjects.SelectedItem); //gets the text in the list box
                if (text == sub.SubjectFirstName.ToString())
                {
                    
                    subAndQuestions.Add(sub.SubjectID);
                    subAndQuestions.Add(sub.SubjectFirstName);
                    subAndQuestions.Add(sub.SubjectLastName);
                    //tested using Message box, working, all details here added. Move to next form and pass list into constructor

                    labelSelected.Show();
                    labelSelect.Hide();
                    btnSelectSub.Hide();
                    btnClearSelection.Show();
                    btnContinue.Enabled = true;

                }
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            subAndQuestions.Clear();
            btnClearSelection.Hide();
            btnSelectSub.Show();
            labelSelected.Hide();
            labelSelect.Show();
            btnContinue.Enabled = false;

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamSelectQuestion f = new FormExamSelectQuestion(Model, subAndQuestions);
            f.ShowDialog();
            this.Close();
        }
    }
}
