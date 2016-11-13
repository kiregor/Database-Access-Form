using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechFeedbackGenerator
{
    class Queries
    {
        public static String methodss(string tagName)
        {
            String TagContentQuery = "SELECT Content FROM tblContent WHERE tblcontent.TagID IN (SELECT TagID FROM tblTags WHERE TagName = '" + tagName + "')";
            return TagContentQuery;
        }
        
        //public static String TagContentQuery = "SELECT Content FROM tblContent WHERE tblcontent.TagID IN (SELECT TagID FROM tblTags WHERE TagName = '";
        //public static String queryfinish = "')";
    }

    
}
    //public static String TagContentQuery = "SELECT Content FROM tblContent WHERE tblcontent.TagID IN (SELECT TagID FROM tblTags WHERE TagName = '<123>')";
