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
    public partial class Configuration : Form
    {
        private IModel Model;
        public Configuration(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;

        }
        private void btnSelectSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamSelectSubject f = new FormExamSelectSubject(Model);
            f.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu fmm = new FormMainMenu(Model);
            fmm.ShowDialog();
            this.Close();
        }

        private void btnConfigQuestions_Click(object sender, EventArgs e)
        {

        }
    }
}
