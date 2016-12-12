using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HappyTechFeedbackGenerator
{
    class DBConnection
    {
        //Create the necessary variables, the the methods to use.
        private static DBConnection _instance;
        private static string _DBConnectionString;
        private static SqlConnection con;
        private static SqlCommand comm;

        //Get the connection string, so the program will be able to find and connect to the database. 
        public static string DBConnectionString
        {
            set
            {
                _DBConnectionString = value;
            }
        }

        //If the database connection doesn't have an instance, create and return it.
        public static DBConnection GetConInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        //Open the database connection
        public void ConnectionOpen()
        {
            con = new SqlConnection(_DBConnectionString);
            con.Open();
        }

        //Close the database connection.
        public void ConnectionCLose()
        {
            con.Close();
        }

        //Set up the SQL command
        /*public void _SQLCommandSetup(string query)
        {
            comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandText = query;
        }*/

        //Connect to the database and access the required data. After the dataset is created, close the connection.
        public DataSet DBconnection1(string q)
        {
            comm = new SqlCommand();
            string x = q;
            ConnectionOpen();
            comm.Connection = con;
            comm.CommandText = q;

            DataSet dt = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            adapter.Fill(dt);

            ConnectionCLose();

            return dt;
        }

    }
}
