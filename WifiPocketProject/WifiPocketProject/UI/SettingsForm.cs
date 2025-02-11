using BusinessLogic;
using BusinessLogic.Extensions;
using BusinessLogic.Model;
using WifiPocketProject.CommonCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLogic.Model.StaticModel.SettingsModel;

namespace WifiPocketProject.UI
{
    public partial class SettingsForm : Form//BasetForm
    {
        public SettingsForm()
        {

            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            new PortCode().LoadSerialPortsIntoComboBox(comboBoxPorts, lblConnectedPort);
        }


       
    }
}
