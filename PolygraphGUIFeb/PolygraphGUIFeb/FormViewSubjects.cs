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
                    tbSubID.Text = sub.SubjectID;
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
                    btnEditSub.Enabled = true;
                }

                    
            }
        }

        private void FormViewSubjects_Load(object sender, EventArgs e)
        {
            btnDeleteSub.Enabled = false;
            btnEditSub.Enabled = false;
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
            DialogResult result = MessageBox.Show("Delete " + listBoxSubjects.SelectedItem.ToString() + " ? ", "Are you sure?", MessageBoxButtons.OKCancel);

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
                        tbSubID.Clear();
                        tbCustName.Clear();
                        break;
                    }
                }
            }
        }

        private void btnEditSub_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFirstName.Text) && !String.IsNullOrEmpty(tbLastName.Text) && !String.IsNullOrEmpty(tbSubAdd.Text) && !String.IsNullOrEmpty(tbPrevTest.Text)
              && !String.IsNullOrEmpty(tbCustName.Text) && !String.IsNullOrEmpty(tbIncar.Text))
            {
                foreach (Subject s in Model.SubjectList)
                {
                    if (tbSubID.Text == s.SubjectID)
                    {
                        
                        s.SubjectFirstName = tbFirstName.Text;
                        s.SubjectLastName = tbLastName.Text;
                       // s.Incarceration = Convert.ToInt32(tbIncar.Text);
                        if(tbIncar.Text == "No")
                        {
                            s.Incarceration = 0;
                        }
                        else if (tbIncar.Text =="Yes")
                        {
                            s.Incarceration = 1;
                        }
                        s.PreviousTests = Convert.ToInt32(tbPrevTest.Text);
                        s.SubjectAddress = tbSubAdd.Text;
                        s.CustodianName = tbCustName.Text;

                        if (Model.UpdateSubject(s))
                        {
                            MessageBox.Show("Subject" + s.SubjectFirstName + " " + s.SubjectLastName + " has been updated Successfully!");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter all information about Subject");
            }
            //this.Hide();
            //FormEditSubject fes = new FormEditSubject(Model);
            //fes.ShowDialog();
            //this.Close();
        }
    }
}
