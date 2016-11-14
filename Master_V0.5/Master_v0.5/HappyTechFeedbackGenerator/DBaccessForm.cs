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
        //Creates an empty string which will be use to pass the data between two forms.
        public static string txtPass = string.Empty;

        //Sets the source of the datagrid view and adds the checkbox column called feedback.
        public void getGrid(DataTable dt)
        {
            if (dataGridView1.DataSource == null)
            {
                dataGridView1.Columns.Add(feedback);
                dataGridView1.Columns[0].HeaderCell.Value = "feedback";
            }
            dataGridView1.DataSource = dt;
        }
   
        //Initial methods when the form is run, basically gets the text from file and shoves it into the textbox.
        public DBaccessForm()
        {
            InitializeComponent();
            string s12 = DBContentAccess.accessstring();
            this.richTextBox1.AppendText(s12);
        }

        //Initial highlighting of the very first tag, avoids confusion and future selection errors.
        private void DBaccessForm_Load(object sender, EventArgs e)
        {
            DBContentAccess.selectionHighlight(label1, richTextBox1);
        }

        //Shows content for the next tag and highlights the appropriate tag.
        private void button1_Click(object sender, EventArgs e)
        {   
            DBContentAccess.NEXTmethod();
            DBContentAccess.selectionHighlight(label1, richTextBox1);
        }

        //Shows content for the previous tag and highlights the appropriate tag.
        private void button2_Click(object sender, EventArgs e)
        {
            DBContentAccess.PREVIOUSmethod();
            DBContentAccess.selectionHighlight(label1, richTextBox1);
        }

        //Adds text to the second textbox
        private void button3_Click(object sender, EventArgs e)
        {
            DBContentAccess.addText(richTextBox2, dataGridView1);
        }

        //Passes the text to a new form, initialises the new form and shows it.
        private void button4_Click(object sender, EventArgs e)
        {
            txtPass = richTextBox2.Text;
            FeedbackDoubleCheckfrm frmDoubleCheck = new FeedbackDoubleCheckfrm();
            frmDoubleCheck.Show();
        }
    }
}
