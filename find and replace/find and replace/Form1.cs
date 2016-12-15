using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace find_and_replace
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textBox2 = textBox3.Text;
            string result = "";
            for (int i = 0; i < textBox2.Length; i++)
            {
                char c = textBox2[i];
                if (c % 2 == 0)
                {
                    c--;
                }
                else
                {
                    c++;
                }
                result += c;
            }
            textBox3.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
