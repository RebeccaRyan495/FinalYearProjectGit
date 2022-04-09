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
    public partial class FormAddCustomQuestion : Form
    {
        private IModel Model;

        public FormAddCustomQuestion(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbQuestion.Text))
            {
                FormConfirmQuestion f = new FormConfirmQuestion(Model);

                if (f.ShowDialog(this) == DialogResult.OK)
                {

                    if (Model.addQuestion(tbQuestion.Text))
                    {
                        MessageBox.Show("Question Added");

                    }
                    this.Hide();
                    FormViewQuestions ff = new FormViewQuestions(Model);
                    ff.ShowDialog();
                    this.Close();

                }
            }
            


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewQuestions f = new FormViewQuestions(Model);
            f.ShowDialog();
            this.Close();
        }
    }
}
