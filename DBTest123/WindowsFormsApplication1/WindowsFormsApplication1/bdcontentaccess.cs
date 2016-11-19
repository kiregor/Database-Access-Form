using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class bdcontentaccess
    {
        public static void mainn()
        {
            string s1 = "Select * From tbl123";
            DataSet ds1 = DB.GetConInstance().DBconnection1(s1);
            DataTable dtt = ds1.Tables[0];
            dgv dgvv = new dgv();
            dgvv.getGrid(dtt);
            dgvv.ShowDialog();

        }

        public static void datainster()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                //string s1 = "insert into tbl123 (name, admin) Values (qwerty, true)";
                SqlCommand cmd = new SqlCommand("insert into tbl123 (name, admin) Values (@name, @admin)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@name", "kacper");
                cmd.Parameters.AddWithValue("@admin", "true");
                connection.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}
