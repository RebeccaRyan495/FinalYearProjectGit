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
    public partial class FormMainMenu : Form
    {
        private IModel Model;
        public FormMainMenu(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;

        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            Model.GetAllAdmin();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewSubjects f = new FormViewSubjects(Model);
            f.ShowDialog();
            this.Close();
        }

        private void btnViewQuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewQuestions f = new FormViewQuestions(Model);
            f.ShowDialog();
            this.Close();
        }

        private void btnExamConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuration fecm = new Configuration(Model);
            fecm.ShowDialog();
            this.Close();

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateCredentials fuc = new FormUpdateCredentials(Model);
            fuc.ShowDialog();
            this.Close();
        }
    }
}
