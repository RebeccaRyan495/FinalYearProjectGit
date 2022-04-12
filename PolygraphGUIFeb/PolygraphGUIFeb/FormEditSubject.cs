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
    public partial class FormEditSubject : Form
    {

        private IModel Model;
        public FormEditSubject(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;

        }


        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewSubjects f = new FormViewSubjects(Model);
            f.ShowDialog();
            this.Close();
        }

        private void btnEditSub_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFirstName.Text) && !String.IsNullOrEmpty(tbLastName.Text) && !String.IsNullOrEmpty(tbSubAdd.Text) && !String.IsNullOrEmpty(tbPrevTest.Text)
               && !String.IsNullOrEmpty(tbCustName.Text) && !String.IsNullOrEmpty(comboIncar.Text))
            {
                foreach (Subject s in Model.SubjectList)
                {
                    if (tbFirstName.Text == s.SubjectFirstName && tbLastName.Text == s.SubjectLastName)
                    {
                        s.SubjectFirstName = tbFirstName.Text;
                        s.SubjectLastName = tbLastName.Text;
                        s.Incarceration = comboIncar.SelectedIndex;
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
        }
    }
}