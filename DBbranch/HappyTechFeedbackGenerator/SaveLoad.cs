using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HappyTechFeedbackGenerator
{
    class SaveLoad
    {
        static public void save(string saveText, string initialDirectory)
        {
            //SFD = SaveFileDialog - Dialog that opens the saving browser
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "template files (*.tlt) |*.tlt| All files (*.*)|*.*";
            SFD.DefaultExt = "tlt";
            if (initialDirectory != "")
            {
                SFD.InitialDirectory = initialDirectory;
            }
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                // Create an instance of StreamWriter to write to a file.
                // The using statement also closes the StreamWriter.
                using (StreamWriter File = new StreamWriter(SFD.FileName))
                {
                    //Write the text to the file
                    File.WriteLine(saveText);
                }
            }
        }

        static public string load()
        {
            string loadText;
            //OFD = OpenFileDialog - Dialog that opens the opening browser
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "template files (*.tlt) |*.tlt| All files (*.*)|*.*";
            DialogResult result = OFD.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(OFD.FileName))
                {
                    string line;
                    StringBuilder load = new StringBuilder();
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        load.Append(line);
                    }
                    loadText = load.ToString();
                }
            }

            else
            {
                loadText = "fail";
            }
            return loadText;
        }

        static public string browse()
        {
            //FBD = SaveFileDialog - Dialog that opens the saving browser
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = true;
            FBD.ShowDialog();
            string fileLocation = FBD.SelectedPath;
            return fileLocation;
        }
    }
}
