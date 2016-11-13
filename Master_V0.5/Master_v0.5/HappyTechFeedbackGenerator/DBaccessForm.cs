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
        public static string txtPass = string.Empty;

        public void getGrid(DataTable dt)
        {
            if (dataGridView1.DataSource == null)
            {
                dataGridView1.Columns.Add(feedback);
                dataGridView1.Columns[0].HeaderCell.Value = "feedback";
            }
            dataGridView1.DataSource = dt;
        }
   

        public DBaccessForm()
        {
            InitializeComponent();
            string s12 = DBContentAccess.accessstring();
            this.richTextBox1.AppendText(s12);
        }

        private void DBaccessForm_Load(object sender, EventArgs e)
        {
            DBContentAccess.selectionHighlight(label1, richTextBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            DBContentAccess.NEXTmethod();
            DBContentAccess.selectionHighlight(label1, richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBContentAccess.PREVIOUSmethod();
            DBContentAccess.selectionHighlight(label1, richTextBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBContentAccess.addText(richTextBox2, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPass = richTextBox2.Text;
            FeedbackDoubleCheckfrm frmDoubleCheck = new FeedbackDoubleCheckfrm();
            frmDoubleCheck.Show();
        }
    }
}
