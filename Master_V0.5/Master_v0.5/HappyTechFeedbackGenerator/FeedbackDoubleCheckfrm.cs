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
    public partial class FeedbackDoubleCheckfrm : Form
    {
        public FeedbackDoubleCheckfrm()
        {
            InitializeComponent();
            richTextBox1.Text = DBaccessForm.txtPass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveLoad.pdfSave(richTextBox1);
            Close();
        }
    }
}
