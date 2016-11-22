using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechFeedbackGenerator
{
    class Queries
    {
        //Method that will return the appropriate query. With this query, only the related content will be displayed in the data grid view.
        public static String methodss(string tagName)
        {
            String TagContentQuery = "SELECT Content FROM tblContent WHERE tblcontent.TagID IN (SELECT TagID FROM tblTags WHERE TagName = '" + tagName + "')";
            return TagContentQuery;
        }

        public static String userCreationQuery(string firstName, string lastName, string username, string password, bool admin)
        {
            int adminCheck = 0;
            if (admin)
            {
                adminCheck = 1;
            }
            string output = "INSERT INTO tblUsers (FirstName, LastName, Username, Password, Admin) VALUES (" + firstName + ", " + lastName + ", " + username + ", " + password + ", " + adminCheck + ")";

            return output;
        }

        public static String userListQuery()
        {
            string output = "SELECT * FROM tblUsers";

            return output;
        }
    }
}
