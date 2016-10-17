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

namespace LOGIN_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stackoverflow.com/questions/18719539/how-to-set-a-path-to-the-local-directory-in-c-sharp-for-mdf-database-in-service
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kacper\Documents\TestDataBase.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + TextBox1.Text + "' and Password ='"+ TextBox2.Text + "'COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainPage MP = new MainPage();
                MP.Show();
            }
            else
            {
                MessageBox.Show("Error, bad username");
            }
        }
    }
}
