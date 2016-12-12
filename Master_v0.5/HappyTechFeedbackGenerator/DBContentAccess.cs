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
        //Create some private variables to use in some of the methods below.
        private static DBaccessForm accessfrm;
        private static List<string> realtaglist;
        private static int i;

        //Accesses the text from the template file.
        public static string accessstring()
        {
            string content123 = SaveLoad.auto;
            return content123;
        }

        //Initialize the DBaccess form, set the value of the list and set the value of i to 0.
        public static void GetFormInstance()
        {
            accessfrm = new DBaccessForm();
            realtaglist = TemplateSplitter.tagList;
            i = 0;
        }

        //Set the value of sq to the query, so the form will display correct information.
        //Set the dataset and datatable, and call the get grid vmethod, which will casue the datagridview to show correct values.
        //If the form is not shown, show it; otherwise it refreshes it with new values.
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

        //Increments the value of i, runs the mainn method to refresh the datagrid view.
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

        //Decrements the value of i, runs the mainn method to refresh the datagrid view.
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

        //this will cause the form to highlight the current tag, to infrom the user which data does the datagrid view relate to.
        public static void selectionHighlight(Label label, RichTextBox textbox)
        {
            string s = realtaglist[i].ToString();
            label.Text = "Selected Tag: " + s;

            textbox.SelectAll();
            textbox.SelectionBackColor = System.Drawing.Color.White;
            textbox.Select(textbox.Text.IndexOf(s), s.Length);
            textbox.SelectionBackColor = System.Drawing.Color.LightBlue;
        }

        //Adds the seletcet text to the second richtextbox, the space is there to divide the sentences/options.
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

        public static DataTable tagContentAccess(List<string> tags, int i)
        {
            string s1 = Queries.methodss(tags[i]);
            DataSet ds1 = DBConnection.GetConInstance().DBconnection1(s1);
            DataTable dt = ds1.Tables[0];
            return dt;
        }
    }
}
