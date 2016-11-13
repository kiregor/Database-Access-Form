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
        private static DBConnection _instance;
        private static string _DBConnectionString;
        private static SqlConnection con;
        private static SqlCommand comm;

        public static string DBConnectionString
        {
            set
            {
                _DBConnectionString = value;
            }
        }

        public static DBConnection GetConInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }

            return _instance;
        }

        public void ConnectionOpen()
        {
            con = new SqlConnection(_DBConnectionString);
            con.Open();
        }

        public void ConnectionCLose()
        {
            con.Close();
        }

        public void _SQLCommandSetup(string query)
        {
            comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandText = query;
        }

        public DataSet DBconnection1(string q)
        {
            comm = new SqlCommand();
            string x = q;
            ConnectionOpen();
            //_SQLCommandSetup(x);
            comm.Connection = con;
            comm.CommandText = q;
            //comm.CommandText = "SELECT Content FROM tblContent WHERE TagID = 1";

            DataSet dt = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            adapter.Fill(dt);

            ConnectionCLose();

            return dt;
        }

    }
}
