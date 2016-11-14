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
    }
}
