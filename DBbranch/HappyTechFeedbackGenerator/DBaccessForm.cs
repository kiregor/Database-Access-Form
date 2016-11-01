using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HappyTechFeedbackGenerator
{
    public partial class DBaccessForm : Form
    {
        public void getGrid(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }
   

        public DBaccessForm()
        {
            InitializeComponent();

            /*
            List<String> tempList = new List<string>
            {"<CV>", "<EXP>", "<123>"};

            foreach(string s in tempList)
            {
                string s1 = Queries.TagContentQuery + s + Queries.queryfinish;
                DataSet ds1 = DBConnection.GetConInstance().DBconnection1(s1);
                DataTable dtt = ds1.Tables[0];
                dataGridView1.DataSource = dtt;
            }
            */



            /*DataSet ds1 = DBConnection.GetConInstance().DBconnection1(s1);
            DataTable dtt = ds1.Tables[0];
            dataGridView1.DataSource = dtt;*/



            //__________WORKING CODE__________//
            /*SqlConnection con = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            con.Open();
            SqlCommand comm = new SqlCommand();

            comm.Connection = con;
            comm.CommandText = "SELECT Content FROM tblContent WHERE TagID = 1";

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;*/
        }
    }
}
