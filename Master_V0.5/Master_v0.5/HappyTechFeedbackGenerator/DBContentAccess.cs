using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace HappyTechFeedbackGenerator
{
    class DBContentAccess
    {
        private static DBaccessForm accessfrm;
        private static List<string> realtaglist;
        private static int i;

        public static string accessstring()
        {
            string content123 = SaveLoad.auto;
            return content123;
        }

        public static void GetFormInstance()
        {
            accessfrm = new DBaccessForm();
            realtaglist = TemplateSplitter.tagList;
            i = 0;
        }

        public static void mainn()
        { 
            string s1 = Queries.methodss(realtaglist[i]);
            DataSet ds1 = DBConnection.GetConInstance().DBconnection1(s1);
            DataTable dtt = ds1.Tables[0];
            accessfrm.getGrid(dtt);
            if (accessfrm.Visible)
            {
                accessfrm.Refresh();
            }
            else if (!accessfrm.Visible)
            {
                accessfrm.ShowDialog();
            }
        }

        public static void NEXTmethod()
        {
            i++;

            if (i >= realtaglist.Count)
            {
                i = realtaglist.Count - 1;
                MessageBox.Show("too many presses");
            }

            mainn();
        }
        public static void PREVIOUSmethod()
        {
            i--;

            if (i < 0)
            {
                i = 0;
                MessageBox.Show("too far back");
            }

            mainn();
        }

        public static void selectionHighlight(Label label, RichTextBox textbox)
        {
            string s = realtaglist[i].ToString();
            label.Text = "Selected Tag: " + s;

            textbox.SelectAll();
            textbox.SelectionBackColor = System.Drawing.Color.White;
            textbox.Select(textbox.Text.IndexOf(s), s.Length);
            textbox.SelectionBackColor = System.Drawing.Color.LightBlue;
        }

        public static void addText(RichTextBox textbox, DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            { 
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    textbox.AppendText(row.Cells[1].Value.ToString());
                    textbox.AppendText(" ");
                }
            }
        }
    }
}
