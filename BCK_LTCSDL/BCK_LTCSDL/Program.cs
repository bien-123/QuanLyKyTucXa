using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BCK_LTCSDL.GUI;
using BCK_LTCSDL.GUI.GAdmin;
using BCK_LTCSDL.GUI.GUser;
namespace BCK_LTCSDL
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
            Application.Run(new GLogin());
        }
    }
}
