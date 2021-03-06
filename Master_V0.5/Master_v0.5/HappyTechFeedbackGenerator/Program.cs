﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechFeedbackGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string conString = Properties.Settings.Default.MyConnectionString;
            DBConnection.DBConnectionString = conString;

            Application.Run(new MainMenu());
        }
    }
}
