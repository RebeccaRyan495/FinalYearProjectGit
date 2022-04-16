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
    public partial class FormExamReviewAndBegin : Form
    {
        private IModel Model;
        private List<string> subAndQuestions;
        

        //public FormExamReviewAndBegin(ModelLayer.IModel model)
        //{
        //    InitializeComponent();
        //}

        public FormExamReviewAndBegin(IModel _Model, List<string> subAndQuestions)
        {

            InitializeComponent();
            Model = _Model;
            this.subAndQuestions = subAndQuestions;
            Model.GetAllQuestions();

        }

        private void testShowList_Click(object sender, EventArgs e)
        {

        }

        private void FormExamReviewAndBegin_Load(object sender, EventArgs e)
        {
            subID.Text = subAndQuestions[0];
            subFirstName.Text = subAndQuestions[1];
            subLastName.Text = subAndQuestions[2];

            for (int i = 4; i < subAndQuestions.Count; i+=2)
            {
                String str = "";
                str += subAndQuestions[i];
                lbSelectedQs.Items.Add(str);
            }

        }

        private void lbSelectedQs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamBegin feb = new FormExamBegin(Model);
            feb.ShowDialog();
            this.Close();

        }
    }
}
