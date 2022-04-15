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
        private List<string> subAndQuestions;

        public FormExamReviewAndBegin(ModelLayer.IModel model)
        {
            InitializeComponent();
        }

        public FormExamReviewAndBegin(IModel model, List<string> subAndQuestions) : this(model)
        {
            this.subAndQuestions = subAndQuestions;
        }
    }
}
