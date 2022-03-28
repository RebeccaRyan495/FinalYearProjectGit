using DataAccess;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygraphGUIFeb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IDataLayer _Datalayer = DataLayer.GetInstance();  // DataLayer object is a singleton, only 1 instance allowed. With Songleton pattern use GetInstance() method to create it.
            IModel _Model = Model.GetInstance(_Datalayer);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormContainer(_Model));

        }
    }
}
