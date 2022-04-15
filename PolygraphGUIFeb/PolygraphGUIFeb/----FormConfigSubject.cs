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
    public partial class FormConfigSubject : Form
    {
        private IModel Model;
        public FormConfigSubject(IModel _Model)
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
                    tbFirstName.Text = sub.SubjectFirstName;
                    tbLastName.Text = sub.SubjectLastName;
                    //tbIncar.Text = sub.Incarceration.ToString();
                    string incar = sub.Incarceration.ToString();
                    if (incar.Equals("0"))
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
                    btnSelectSub.Enabled = true;
                }
            }
        }

        private void btnSelectSub_Click(object sender, EventArgs e)
        {

        }
    }
}
