using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HappyTechFeedbackGenerator
{
    class Template
    {
        //sabing the template
        public static string SaveTemplate(string TemplateBody, string initialDirectory)
        {
            //Header and footer, these will automatically added to the template.
            string header = "<fName> <lName>\n<address>\n\n\n\nDear, <title> <lName>\n";
            string footer = "\nKind regards,\n <staffname>";
            StringBuilder templateSave = new StringBuilder();
            templateSave.Append(header + " " + TemplateBody + footer);
            string saveText = templateSave.ToString();
            SaveLoad.save(saveText, initialDirectory);
            return null;
        }

        //Loading the temlate for new feedback.
        public static void LoadTemplate()
        {
            //bunch of variables necessary for tag finding.
            string templateText = SaveLoad.load();
            
            List<string> tagList = TemplateSplitter.templateSplitter(templateText);

            //Checking if it works
            foreach (string s in tagList)
            {
                string temp = Queries.methodss(s);
                temp.ToString();

                //MessageBox.Show(s);
            }
            DBContentAccess.GetFormInstance();
            DBContentAccess.mainn();
        }
    }
}
