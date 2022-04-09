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
    public partial class FormAddSubject : Form
    {
        private IModel Model;

        public FormAddSubject(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
            string testUser = tbSubFName.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewSubjects f = new FormViewSubjects(Model);
            f.ShowDialog();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSubFName.Text) && !String.IsNullOrEmpty(tbSubLName.Text) && !String.IsNullOrEmpty(tbSubAdd.Text) && !String.IsNullOrEmpty(tbPrevTest.Text)
                && !String.IsNullOrEmpty(tbCustName.Text) && !String.IsNullOrEmpty(comboIncar.Text))
            {
                String incarcer = comboIncar.Text;
                //string id = "0"; //test to see if if it can overcome autoincrement, if not, take out of methods

                ////message box shows up with "would you like to put in this info" if yes - proceed to function, if no, clear

                FormConfirmAddSubject f = new FormConfirmAddSubject(Model);
                if (f.ShowDialog(this) == DialogResult.OK)
                {

                    if (Model.addSubject(tbSubFName.Text, tbSubLName.Text, comboIncar.SelectedIndex, Convert.ToInt32(tbPrevTest.Text), tbSubAdd.Text, tbCustName.Text))
                    {
                        MessageBox.Show("Subject Added");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter subject details");
            }
        }
    }
}
