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
        public static string SaveTemplate(string TemplateBody)
        {
            //Header and footer, these will automatically added to the template.
            string header = "<fName> <lName>\n<address>\n\n\n\nDear, <title> <lName>\n";
            string footer = "Kind regards,\n <staffname>";
            //Temporary directory name, for quick testing. Change that if you want to save on different PC.
            string tempDirectorySave = @"C:\Users\Kacper\Desktop\ExamplePDF.AGR";

            //Streamwriter which will create a new file, add text and close. 
            StreamWriter writer = new StreamWriter(tempDirectorySave);
            writer.WriteLine(header + " " + TemplateBody + footer);
            writer.Close();
            return null;
        }

        //Loading the temlate for new feedback.
        public static void LoadTemplate()
        {
            //bunch of variables necessary for tag finding.
            string tempDirectoryLoad = @"C:\Users\Kacper\Desktop\ExamplePDF.AGR";
            string templateText;
            string tag;
            string textBlock;

            using (StreamReader reader = new StreamReader(tempDirectoryLoad))
            {
                //Read the entire file and place in into a single large string.
                templateText = reader.ReadToEnd();
                //new array which will split the large 'templateText' variable into smaller ones, based on any whitespace.
                string[] templateSplitter = templateText.Split(' ');
                //List to store all found tags.
                List<string> tagList = new List<string>();
                //Go through each string in the array.
                foreach (string templatePortion in templateSplitter)
                {
                    //Since foreach varaible cannot be changed, this variable will be used.
                    textBlock = templatePortion;
                    if (textBlock.Contains("<") && textBlock.Contains(">"))
                    {
                        //Sometimes single string may contain multiple tags, this will find all of them.
                        while (textBlock.Contains("<") && textBlock.Contains(">"))
                        {
                            tag = textBlock.Substring(textBlock.IndexOf("<"), textBlock.IndexOf(">") + 1);
                            if (tag.EndsWith("<"))
                            {
                                tag = tag.Substring(tag.IndexOf("<"), tag.IndexOf(">") + 1);
                                tagList.Add(tag);
                                textBlock = textBlock.Substring(textBlock.IndexOf(">") + 1);
                            }
                            else
                            {
                                tagList.Add(tag);
                                textBlock = textBlock.Substring(textBlock.IndexOf(">") + 1);
                            }
                        }
                    }
                }
                //Checking if it works
                foreach (string s in tagList)
                {
                    MessageBox.Show(s);
                }
            }
        }
    }
}
