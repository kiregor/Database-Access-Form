using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace HappyTechFeedbackGenerator
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            string initialDirectory = txtBoxSaveDirectory.Text;
            Template.SaveTemplate(txtTemplateBox.Text, initialDirectory);
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDirectoryfinder_Click(object sender, EventArgs e)
        {
            txtBoxSaveDirectory.Text = SaveLoad.browse();
        }

    }
}
