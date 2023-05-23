using inventory_system.usercontrol;
using System;
using System.Windows.Forms;

namespace inventory_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new MainForm()); // Create and run the main form
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            // Add the user control to the main form
            var userctrlMenu = new userctrlMenu();
            Controls.Add(userctrlMenu);

            // Perform any other necessary configuration for the main form
            // ...
        }
    }
}
