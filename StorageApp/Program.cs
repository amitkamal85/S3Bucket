using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
{
    static class Program
    {
        static string UserName = "";
        static string Password = "";
        static string Path = "";
        static string UserId = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string userRoot = "HKEY_CURRENT_USER" + "\\" + "MyTestKey";
            Path = (string)Registry.GetValue(userRoot, "Path", String.Empty);

            UserName = (string)Registry.GetValue(userRoot, "UserName", String.Empty);
            Password = (string)Registry.GetValue(userRoot, "Password", String.Empty);
            UserId = (string)Registry.GetValue(userRoot, "UserId", String.Empty);


            if (String.IsNullOrEmpty(UserName) || String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(Path) || String.IsNullOrEmpty(UserId))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
            else
            {
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Timer());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Dashboard());
            }
        }
    }
}
