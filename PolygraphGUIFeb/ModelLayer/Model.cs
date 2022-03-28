using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessEntities;

namespace ModelLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion


        #region Instance Attributes
        private IDataLayer dataLayer;
        //private Admin admin;
        private List<IAdmin> adminList;
        private ArrayList subjectList;
        #endregion

        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }

        public List<IAdmin> AdminList
        {
            get
            {
                return adminList;
            }
            set
            {
                adminList = value;
            }
        }
        #endregion

        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            dataLayer = _DataLayer;
            adminList = dataLayer.getAllAdmin(); // setup Models userList so we can login
        }

        #endregion

        public void GetAllAdmin()
        {
            AdminList = dataLayer.getAllAdmin();

        }
    }
}

