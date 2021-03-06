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
        private List<ISubject> subjectList;
        private List<IDataDevice> datadeviceList;
        private List<IQuestion> questionList;
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

        public List<IDataDevice> DataDeviceList
        {
            get
            {
                return datadeviceList;
            }
            set
            {
                datadeviceList = value;
            }
        }

        public List<ISubject> SubjectList
        {
            get
            {
                return subjectList;
            }
            set
            {
                subjectList = value;
            }
        }

        public List<IQuestion> QuestionList
        {
            get
            {
                return questionList;
            }
            set
            {
                questionList = value;
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
        public Boolean login(String username, String password)
        {

            foreach (Admin admin in adminList)
            {
                if (username == admin.UserName && password == admin.Password)
                {

                    
                    return true;
                }
            }
            return false;
        }

        public bool deleteSubject(ISubject sub)
        {

            DataLayer.deleteSubject(sub);
            SubjectList.Remove(sub); //remove object from collection
            return true;

        }
        public Boolean addSubject(string SubjectFName, string SubjectLName, int Incarceration, int PreviousTests, string SubjectAddress, string CustodianName)
        {
            try
            {
                int maxId = 0;

                foreach (Subject s in subjectList)
                {
                    if (Convert.ToInt32(s.SubjectID) > maxId)
                        maxId = Convert.ToInt32(s.SubjectID);
                }

                ISubject subject = SubjectMethods.GetSubject(Convert.ToString(maxId + 1), SubjectFName, SubjectLName, Incarceration, PreviousTests, SubjectAddress, CustodianName);
                DataLayer.addSubject(subject);
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
                return false;
            }
        }

        public Boolean addQuestion(string Question)
        {
            try
            {
                int maxId = 0;

                foreach (Question q in questionList)
                {
                    if (Convert.ToInt32(q.QuestionID) > maxId)
                        maxId = Convert.ToInt32(q.QuestionID);
                }

                IQuestion question = QuestionMethods.GetQuestion(Convert.ToString(maxId + 1), Question);
                DataLayer.addQuestion(question);
                return true;
            }
            catch (System.Exception excep)
            {

                return false;
            }
        }

        public bool UpdateSubject(ISubject subject)
        {
            dataLayer.updateSubject(subject);
            return true;
        }

        public bool UpdateAdmin(IAdmin admin)
        {
            dataLayer.updateAdmin(admin);
            return true;
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

        public void GetAllDataDevice()
        {
            DataDeviceList= dataLayer.getAllData();

        }

        public void GetAllSubjects()
        {
            SubjectList = dataLayer.getAllSubjects();
        }

        public void GetAllQuestions()
        {
            QuestionList = dataLayer.getAllQuestions();
        }

    }
}

