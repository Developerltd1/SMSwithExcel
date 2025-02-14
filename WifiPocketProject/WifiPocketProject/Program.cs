using WifiPocketProject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WifiPocketProject.UI.Form2;

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
            
                    Application.Run(new MsgTemplete());
            // Application.Run(new AboutUsForm());
          //  Application.Run(new ExportData());
            //Application.Run(new MainForm());
            //Application.Run(new SettingsForm());
            //Application.Run(new SandBox());

        }
    }
}
