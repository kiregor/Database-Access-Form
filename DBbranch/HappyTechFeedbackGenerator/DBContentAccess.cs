using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HappyTechFeedbackGenerator
{
    class DBContentAccess
    {
        public static void GetFormInstance()
        {
            DBaccessForm accessfrm = new DBaccessForm();

            List<String> tempList = new List<string>
            {"<CV>", "<EXP>", "<123>"};

            foreach (string s in tempList)
            {
                string s1 = Queries.TagContentQuery + s + Queries.queryfinish;
                DataSet ds1 = DBConnection.GetConInstance().DBconnection1(s1);
                DataTable dtt = ds1.Tables[0];

                accessfrm.getGrid(dtt);

                accessfrm.Show();
            }
        }
    }
}
