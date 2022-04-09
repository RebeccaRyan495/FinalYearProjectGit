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
    public partial class FormViewSubjects : Form
    {
        private IModel Model;
        public FormViewSubjects(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;

        }


        private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Subject sub in Model.SubjectList)
            {
                string text = listBoxSubjects.GetItemText(listBoxSubjects.SelectedItem); //gets the text in the list box
                if (text == sub.SubjectFirstName.ToString())
                {
                    tbFirstName.Text = sub.SubjectFirstName;
                    tbLastName.Text = sub.SubjectLastName;
                    //tbIncar.Text = sub.Incarceration.ToString();
                    string incar = sub.Incarceration.ToString();
                    if(incar.Equals("0"))
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
                    btnDeleteSub.Enabled = true;
                }

                    
            }
        }

        private void FormViewSubjects_Load(object sender, EventArgs e)
        {
            btnDeleteSub.Enabled = false;
            listBoxSubjects.Items.Clear();
            Model.GetAllSubjects();

            foreach (ISubject subject in Model.SubjectList)
            {
                //String str = "";
                //str += subject.SubjectLastName + ", ";
                //str += subject.SubjectFirstName;
                string str = subject.SubjectFirstName;
                listBoxSubjects.Items.Add(str);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu f = new FormMainMenu(Model);
            f.ShowDialog();
            this.Close();
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSubject f = new FormAddSubject(Model);
            f.ShowDialog();
            this.Close();
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + listBoxSubjects.SelectedItem.ToString() + " ? ", "Are you sure !", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                foreach (Subject sub in Model.SubjectList)
                {
                    if (sub.SubjectFirstName == listBoxSubjects.SelectedItem.ToString())
                    {
                        Model.deleteSubject(sub);
                        listBoxSubjects.Items.Remove(listBoxSubjects.SelectedItem); //remove name from listbox
                        tbFirstName.Clear();
                        tbLastName.Clear();
                        tbIncar.Clear();
                        tbPrevTest.Clear();
                        tbSubAdd.Clear();
                        tbCustName.Clear();
                        break;
                    }
                }
            }
        }
    }
}
