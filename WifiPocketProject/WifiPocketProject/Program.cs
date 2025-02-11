using WifiPocketProject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiPocketProject
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
            //Application.Run(new DashBoard1());
            Application.Run(new MainForm());
            //Application.Run(new SettingsForm());
           //Application.Run(new SandBox());

        }
    }
}
