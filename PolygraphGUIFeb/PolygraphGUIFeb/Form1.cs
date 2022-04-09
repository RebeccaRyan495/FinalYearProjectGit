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
    public partial class FormContainer : Form
    {
        private IModel Model;

        public FormContainer(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Model.GetAllAdmin();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool validUser = Model.login(username, password);

            if (validUser)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                FormMainMenu frmMM = new FormMainMenu(Model);
                frmMM.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid name or password");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
