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
    }
}
