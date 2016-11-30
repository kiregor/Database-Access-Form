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

        public static string insert(string tag)
        {
            string TagInsertQuery = "INSERT into tblTags (tagName) Values ('" + tag + "')";
            return TagInsertQuery;
        }

        public static string addTagContent(string Tag, string input)
        {
            string TagContentInsertQuery = "INSERT into tblContent (TagID, Content) Values ((SELECT TagID FROM tblTags WHERE TagName = '" + Tag + "'),'" + input + "')";
            return TagContentInsertQuery;
        }

        public static string removeTagContent(string Tag, string removal)
        {
            string TagContentRemovalQuery = "DELETE FROM tblContent WHERE TagID = (SELECT TagID FROM tblTags WHERE TagName = '" + Tag + "') AND Content = '" + removal + "')";
            return TagContentRemovalQuery;
        }

        public static string checkContent(string tag)
        {
            string checkContentQuery = "SELECT COUNT(*) FROM tblContent WHERE TagID = (SELECT TagID FROM tblTags WHERE TagName = '" + tag + "')";
            return checkContentQuery;
        }
    }
}
