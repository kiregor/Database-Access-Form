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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Creates and instance of a template form and then it launches it when the big red button is clicked.
        private void bigRedButtonTEMP_Click(object sender, EventArgs e)
        {
            TemplateForm frmTemplate  = new TemplateForm();
            frmTemplate.FormClosed += (s, args) => this.Show();
            frmTemplate.Show();
            Hide();
        }

        //Event handler
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnNewFeedback_Click(object sender, EventArgs e)
        {
            Template.LoadTemplate();
        }
    }
}
