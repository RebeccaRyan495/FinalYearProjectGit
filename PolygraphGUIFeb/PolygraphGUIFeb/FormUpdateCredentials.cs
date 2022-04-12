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
    public partial class FormUpdateCredentials : Form
    {
        private IModel Model;
        public FormUpdateCredentials(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbUsername1.Text) && !String.IsNullOrEmpty(tbPassword1.Text))
            {
                foreach (Admin a in Model.AdminList)
                {

                    bool validUser = Model.login(tbUsername1.Text, tbPassword1.Text);

                    if (validUser)
                    {
                        labelVerify.Hide();
                        tbPassword1.Hide();
                        tbUsername1.Hide();
                        lblAccept.Show();
                        tbPassword2.Show();
                        tbUsername2.Show();
                        button1.Hide();
                        btnUpdate.Show();

                    }
                    else
                    {
                        //MessageBox.Show("Incorrect username or password");
                        labelVerify.Hide();
                        labelIncorrect.Show();
                        lblEnterAll.Hide();
                        tbPassword1.Clear();
                        tbUsername1.Clear();

                    }
                }
            }
            else
            {
                labelVerify.Hide();
                labelIncorrect.Hide();
                lblEnterAll.Show();
            }

        }

        private void FormUpdateCredentials_Load(object sender, EventArgs e)
        {
            labelVerify.Show();
            labelIncorrect.Hide();
            lblEnterAll.Hide();
            tbPassword2.Hide();
            tbUsername2.Hide();
            lblAccept.Hide();
            btnUpdate.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu fmm = new FormMainMenu(Model);
            fmm.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (Admin a in Model.AdminList)
            {
                
                    a.UserName = tbUsername2.Text;
                    a.Password = tbPassword2.Text;

                    if (Model.UpdateAdmin(a))
                    {
                        MessageBox.Show("Credentials updated");
                        this.Hide();
                        FormMainMenu fmm1 = new FormMainMenu(Model);
                    fmm1.ShowDialog();
                    this.Hide();

                    
                    }
                
            }
        }
    }
}
