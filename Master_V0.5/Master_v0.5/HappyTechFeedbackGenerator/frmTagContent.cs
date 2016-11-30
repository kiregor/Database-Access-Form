using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechFeedbackGenerator
{
    public partial class frmTagContent : Form
    {
        private int currentTag = 0;
        List<string> tags = new List<string>();
        public frmTagContent(List<string> newTags)
        {
            InitializeComponent();
            tags = newTags;


            //Add Tags to DataGridView1
            DataTable dt = new DataTable();
            dt.Columns.Add("Tags");
            foreach(string x in tags)
            {
                dt.Rows.Add(new object[] { x });
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Rows[currentTag].Selected = true;

            //Put Content for the First Tag into DataGridView2
            dataGridView2.DataSource = DBContentAccess.tagContentAccess(tags, currentTag);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNextTag_Click(object sender, EventArgs e)
        {
            currentTag++;
            if (currentTag == tags.Count)
            {
                currentTag--;
                MessageBox.Show("No more tags");
            }
            else
            {
                dataGridView2.DataSource = DBContentAccess.tagContentAccess(tags, currentTag);
                dataGridView1.Rows[currentTag].Selected = true;
            }
        }

        private void btnPreviousTag_Click(object sender, EventArgs e)
        {
            if (currentTag == 0)
            {
                MessageBox.Show("This is the first available tag");
            }
            else
            {
                currentTag--;
                dataGridView2.DataSource = DBContentAccess.tagContentAccess(tags, currentTag);
                dataGridView1.Rows[currentTag].Selected = true;
            }
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            if (!DBConnection.GetConInstance().DBStore(Queries.addTagContent(tags[currentTag], tbxEdit.Text)))
            {
                MessageBox.Show("Failed to Add Content to Database");
            }
            else
            {
                tbxEdit.Text = "";
                dataGridView2.DataSource = DBContentAccess.tagContentAccess(tags, currentTag);
            }
        }

        private void btnRemoveText_Click(object sender, EventArgs e)
        {
            if(!DBConnection.GetConInstance().DBStore(Queries.removeTagContent(tags[currentTag], tbxEdit.Text)))
            {
                MessageBox.Show("Failed to Remove the Requested Entry");
            }
            else
            {
                tbxEdit.Text = "";
                dataGridView2.DataSource = DBContentAccess.tagContentAccess(tags, currentTag);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(tagContentCheck())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("There are Tags that do not have associated content");
            }
        }

        private bool tagContentCheck()
        {
            bool check = true;
            foreach(string x in tags)
            {
                if (check)
                {
                    if (!DBConnection.GetConInstance().DBCheck(Queries.checkContent(x)))
                    {
                        check = false;
                    }
                }
            }
            return check;
        }
    }
}
