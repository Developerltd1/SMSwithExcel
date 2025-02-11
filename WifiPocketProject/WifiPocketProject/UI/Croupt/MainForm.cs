using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiPocketProject.UI
{
    public partial class MainForm : Form//d BasetForm
    {
        Dashboard dashboard;
        AboutUsForm aboutUsForm;
        SettingsForm settingsForm;
        SandBox SandBox;
        ExportData  exportData;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnBtnDashboard_Click(null, null);


        }
       



        bool sidebarExpand = true;
        private void SidebarTransaction_Tick(object sender, EventArgs e)  //Timer
        {
            if (sidebarExpand)
            {
                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width <= 65)
                {
                    sidebarExpand = false;
                    SidebarTransaction.Stop();
                    //widthtoSidePanel();
                }
            }
            else
            {
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width >= 166)
                {
                    sidebarExpand = true;
                    SidebarTransaction.Stop();
                   // widthtoSidePanel();

                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransaction.Start();
        }



        //FUNCATIONS
        public void widthtoSidePanel()
        {
            pnBtnMenu.Width = sidebarPanel.Width;
            pnBtnSetting.Width = sidebarPanel.Width;
            pnBtnAboutUs.Width = sidebarPanel.Width;
            pnBtnLogout.Width = sidebarPanel.Width;
            MenuContainer.Width = sidebarPanel.Width;
        }

        private void pnBtnAboutUs_Click(object sender, EventArgs e)
        {
            if (aboutUsForm == null)
            {
                aboutUsForm = new AboutUsForm();
                aboutUsForm.FormClosed += AboutUsForm_FormClosed;
                aboutUsForm.MdiParent = this;
                aboutUsForm.Dock = DockStyle.Fill;
                aboutUsForm.Show();
            }
            else
            {
                aboutUsForm.Activate();
            }
        }

        private void AboutUsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            aboutUsForm = null;
        }

        private void pnBtnSetting_Click(object sender, EventArgs e)
        {
            if (settingsForm == null)
            {
                settingsForm = new SettingsForm();
                settingsForm.FormClosed += SettingsForm_FormClosed;
                settingsForm.MdiParent = this;
                settingsForm.Dock = DockStyle.Fill;
                settingsForm.Show();
            }
            else
            {
                settingsForm.Activate();
            }
        }
        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsForm = null;
        }

        private void pnBtnMenu_Click(object sender, EventArgs e)
        {
            if (SandBox == null)
            {
                SandBox = new SandBox();
                SandBox.FormClosed += SandBox_FormClosed;
                SandBox.MdiParent = this;
                SandBox.Dock = DockStyle.Fill;
                SandBox.Show();
            }
            else
            {
                SandBox.Activate();
            }
            
        }
        private void SandBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            SandBox = null;
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void pnBtnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnBtnDataExport_Click(object sender, EventArgs e)
        {
            if (exportData == null)
            {
                exportData = new ExportData();
                exportData.FormClosed += DataExport_FormClosed;
                exportData.MdiParent = this;
                exportData.Dock = DockStyle.Fill;
                exportData.Show();
            }
            else
            {
                exportData.Activate();
            }
        }
        private void DataExport_FormClosed(object sender, FormClosedEventArgs e)
        {
            exportData = null;
        }

        private void pnBtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
