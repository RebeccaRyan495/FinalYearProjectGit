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

        }

        private void FormViewSubjects_Load(object sender, EventArgs e)
        {
            listBoxSubjects.Items.Clear();
            Model.GetAllSubjects();

            foreach (ISubject subject in Model.SubjectList)
            {
                String str = "";
                str += subject.SubjectLastName + ", ";
                str += subject.SubjectFirstName;
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
    }
}
