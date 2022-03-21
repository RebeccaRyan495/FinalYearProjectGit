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
    public class DataLayer:IDataLayer
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
            con.ConnectionString = "Server=localhost;Database=polygraphdb;User Id=root;Password='';";
            //con.ConnectionString = "Data Source=BDEV2 ;Initial Catalog=ProductTracker;Integrated Security=True";
            /*       con.ConnectionString = "Data Source=SQL02.student.litdom.lit.ie\\SD3A ;Initial Catalog=ProductTracker;Integrated Security=True";
                     This last conection string is for SQL02.student.litdom.lit.ie\SD3A  Note the extra (slash)\ in the code. This is needed in the lab 
                     for the extra instances Annette Bowman sets up on the CS SQL Server*/
            try
            {
                con.Open();
                MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
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


        public ArrayList getAllAdmin()
        {
            ArrayList adminList = new ArrayList();

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
    }
}
