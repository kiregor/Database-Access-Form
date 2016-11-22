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
    public partial class frmUserCreation : Form
    {
        public frmUserCreation()
        {
            InitializeComponent();
            DataTable dt = DBContentAccess.UserQuery();
            dataGridView1.DataSource = dt;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxPasswordConf.Text)
            {
                DBContentAccess.userCreation(tbxFirstName.Text, tbxLastName.Text, tbxUsername.Text, tbxPassword.Text, rbAdmin.Checked);
            }
            else
            {
                IWin32Window owner = this;
                MessageBox.Show(owner, "Passwords do not match!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
