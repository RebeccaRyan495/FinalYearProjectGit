using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;

namespace DataAccess
{
    public class DataLayer : IDataLayer
    {

        #region Instance Attributes
        private SqlConnection con;   // DB Connection
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;          //Declare the DataAdapter object
        int maxRows;
        SqlCommandBuilder cb;
        #endregion

        private static IDataLayer dataLayerSingletonInstance;  // DataLayer object is a singleton so only one instance allowed
        static readonly object padlock = new object();

        public static IDataLayer GetInstance() // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }


        private DataLayer()  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            openConnection();
        }


        public void openConnection()
        {
            con = new SqlConnection();
            //con.ConnectionString = "Server=MSSQLSERVER01;Database=PolygraphDB;Initial Catalog=PolygraphDB;Integrated Security=true;uid=root;pwd='';";
            con.ConnectionString = @"Data Source=localhost\MSSQLSERVER01; Initial Catalog=polygraphdb; Integrated Security=True";

            // ConnectionState.ConnectionString = @"Data Source=localhost;Initial Catalog=myNFCdb;Integrated Security=True";

            try
            {
                con.Open();
                MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show("Cannot connect to database");
                Environment.Exit(0); //Force the application to close
            }
        }

        public void closeConnection()
        {
            con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public virtual List<ISubject> getAllSubjects()
        {
            List<ISubject> subjectList = new List<ISubject>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Subject";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "SubjectData");
                maxRows = ds.Tables["SubjectData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["SubjectData"].Rows[i];
                    ISubject subject = SubjectMethods.GetSubject(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                         Convert.ToInt16(dRow.ItemArray.GetValue(3).ToString()),
                                                         Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                                                        dRow.ItemArray.GetValue(5).ToString(),
                                                        dRow.ItemArray.GetValue(6).ToString());
                    subjectList.Add(subject);
                    //MessageBox.Show(user.Username + user.Password);

                    //textBoxName.Select();
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }

            return subjectList;

        }

        public bool deleteSubject(BusinessEntities.ISubject sub)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Subject";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "SubjectData");
                DataRow findRow = ds.Tables["SubjectData"].Rows.Find(sub.SubjectID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "SubjectData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }


        public virtual List<IAdmin> getAllAdmin()
        {
            List<IAdmin> adminList = new List<IAdmin>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Admin";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdminData");
                maxRows = ds.Tables["AdminData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["AdminData"].Rows[i];
                    IAdmin admin = AdminMethods.GetAdmin(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString());
                    adminList.Add(admin);
                    //MessageBox.Show(user.Username + user.Password);

                    //textBoxName.Select();
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }



            return adminList;

        }

        public virtual List<IQuestion> getAllQuestions()
        {
            List<IQuestion> questionList = new List<IQuestion>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Question";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "QuestionData");
                maxRows = ds.Tables["QuestionData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["QuestionData"].Rows[i];
                    IQuestion question = QuestionMethods.GetQuestion(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString());
                    questionList.Add(question);
                    //MessageBox.Show(user.Username + user.Password);

                    //textBoxName.Select();
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }



            return questionList;

        }

        public virtual void addSubject(ISubject subject)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Subject";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "SubjectData");
                maxRows = ds.Tables["SubjectData"].Rows.Count;
                DataRow dRow = ds.Tables["SubjectData"].NewRow();
                dRow[0] = subject.SubjectID;
                dRow[1] = subject.SubjectFirstName;
                dRow[2] = subject.SubjectLastName;
                dRow[3] = subject.Incarceration;
                dRow[4] = subject.PreviousTests;
                dRow[5] = subject.SubjectAddress;
                dRow[6] = subject.CustodianName;



                ds.Tables["SubjectData"].Rows.Add(dRow);
                da.Update(ds, "SubjectData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "Unable to add Subject to database");
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
        }

        public virtual void addQuestion(IQuestion question)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Question";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "QuestionData");
                maxRows = ds.Tables["QuestionData"].Rows.Count;
                DataRow dRow = ds.Tables["QuestionData"].NewRow();
                dRow[0] = question.QuestionID;
                dRow[1] = question.AQuestion;




                ds.Tables["QuestionData"].Rows.Add(dRow);
                da.Update(ds, "QuestionData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "Unable to add Question to database");
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
        }

        public virtual bool updateSubject(ISubject subject)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Subject";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "SubjectData");
                DataRow findRow = ds.Tables["SubjectData"].Rows.Find(subject.SubjectID);
                if (findRow != null)
                {
                    //findRow[0] = stockItem.ItemID;
                    findRow[1] = subject.SubjectFirstName;
                    findRow[2] = subject.SubjectLastName;
                    findRow[3] = subject.Incarceration;
                    findRow[4] = subject.PreviousTests;
                    findRow[5] = subject.SubjectAddress;
                    findRow[6] = subject.CustodianName;

                }
                da.Update(ds, "SubjectData"); //remove row from database table

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public virtual bool updateAdmin(IAdmin admin)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Admin";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdminData");
                DataRow findRow = ds.Tables["AdminData"].Rows.Find(admin.AdminID);
                if (findRow != null)
                {
                    //findRow[0] = stockItem.ItemID;
                    findRow[1] = admin.AdminFirstName;
                    findRow[2] = admin.AdminLastName;
                    findRow[3] = admin.UserName;
                    findRow[4] = admin.Password;
                }
                da.Update(ds, "AdminData"); //remove row from database table

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
    }
}
