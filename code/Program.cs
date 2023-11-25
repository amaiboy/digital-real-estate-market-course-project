using code.Classes;
using System;
using System.Windows.Forms;

namespace code
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            Application.Run(new FormMenu());
        }
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            FileHandler.UserFileWriter(GlobalData.Users);
            FileHandler.saveAdToCSV(GlobalData.AvailableListings);
        }
    }
}
