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
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        public TemplateForm(List<string> load)
        {
            InitializeComponent();
            txtTemplateBox.Text = load[0];
            txtBoxSaveDirectory.Text = load[1];
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            string initialDirectory = txtBoxSaveDirectory.Text;
            Template.SaveTemplate(txtTemplateBox.Text, initialDirectory);
            List<string> tagList = TemplateSplitter.templateSplitter(txtTemplateBox.Text);
            if (!(tagList.Count == 0))
            {
                foreach (string x in tagList)
                {
                    if (!DBConnection.GetConInstance().DBStore(Queries.insert(x)))
                    {
                        MessageBox.Show("Duplicate Tag");
                    }
                }
                frmTagContent tagContent = new frmTagContent(tagList);
                tagContent.FormClosed += (s, args) => this.Close();
                tagContent.Show();
                this.Hide();
            }
            else
            {
                if(MessageBox.Show(this,"There are no tags in this template, are you sure you wish to continue?", "Tag Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
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
