using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DataAccessTier
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

        private static IDataLayer dataLayerSingletonInstance;  // DataLayer object is singleton - only one instance allowed
        static readonly object padlock = new object(); // Used for thread safety on the DataLayer singleton creation


        public static IDataLayer GetInstance() // Used GetInstance here instead of constructor
        {
            lock (padlock) //   only one thread can enter
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }

        private DataLayer()  // The constructor is private as it is singleton
        {
            openConnection();
        }


        public void openConnection()
        {
            con = new SqlConnection();
            //con.ConnectionString = "Server=SQL5.student.litdom.lit.ie\\TEAM2, 60152;Database=BloomFeildHotel;User Id=k00235626;Password=$QLT3AM02;";
            //UPDATE THIS TO REFLECT WORKBENCH FOR FYP
            try
            {
                con.Open();
                //MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                //MessageBox.Show(excep.Message);
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
    }
}
