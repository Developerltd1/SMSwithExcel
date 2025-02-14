﻿using BusinessLogic;
using BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static BusinessLogic.Model.StaticModel;
using WifiPocketProject.CommonCode;

namespace WifiPocketProject.UI
{
    public partial class SandBox : Form//BasetForm
    {

        private Timer pollingTimer;
        private bool isPollingEnabled = false;
        public SandBox()
        {
            InitializeComponent();
            MainParamatersForm_Load(null,null);
        }
        

        //FUNCATIONS
        #region FUNCATIONS
        private void BtnTogglePolling_Click(object sender, EventArgs e)
        {
            isPollingEnabled = !isPollingEnabled;

            if (isPollingEnabled)
            {
                InitializePollingTimer();
                StartPolling();
            }
            else
            {
                StopPolling();

            }
        }
        private void InitializePollingTimer()
        {
            pollingTimer = new Timer();
            pollingTimer.Interval = 500;// Convert.ToInt32(pollingTimeout.Value); // Polling interval in milliseconds (1 second here)
            pollingTimer.Tick += PollingTimer_Tick;
        }
        private void StartPolling()
        {
            pollingTimer.Start();
        }
        private void StopPolling()
        {
            pollingTimer.Stop();
        }
        private void PollingTimer_Tick(object sender, EventArgs e)
        {
            
        }
         
        private DataTable SetupDataGridView()
        {
            DataTable dt = new StaticData().DataGridView();
            dgvCellLevel.Rows.Clear();
            foreach (DataRow r in dt.Rows)
            {
                dgvCellLevel.Rows.Add(
                    r["Parameter"].ToString(), r["Battery-1"].ToString(), r["Battery-2"].ToString(), r["Battery-3"].ToString(), r["Battery-4"].ToString(), r["Battery-5"].ToString());
            }
            return dt;
        }

        #endregion
    
        private void MainParamatersForm_Load(object sender, EventArgs e)
        {
            new PortCode().LoadSerialPortsIntoComboBox(comPorts, null);
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            // Example list of 10 phone numbers
            List<string> phoneNumbers = new List<string>
            {
                "+923349149169",
                "+923349149169"
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169",
                //"+923349149169"

            };

            // Step 1: Check if a valid port is connected
            if (!PortCode.IsPortConnected())
            {
                MessageBox.Show("No valid COM port detected. Please connect a '3G PC UI Interface' device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Get the available COM port
            string availablePort = PortCode.GetAvailablePort();
            if (string.IsNullOrEmpty(availablePort))
            {
                MessageBox.Show("No valid COM port found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 3: Validate and format the phone number
            string phoneNumber = FilterNumber.FormatPhoneNumber(tbContactNo.Text.Trim());
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Invalid phone number format. Please enter a valid Pakistani number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 4: Get the message text
            string messageText = tbMessage.Text;
            //messageText = "Naqash Studio is Shifted. New Address: Dr.Nargis Nazir Street, Opposite Orangze Car Parking, Main Saddar Road Peshawar Cantt. Google Map Location: https://maps.app.goo.gl/j53aJt291V64r5zTA Contact: 0345-9195827";
            messageText = "Naqash Studio is Shifted.";
            if (string.IsNullOrEmpty(messageText))
            {
                MessageBox.Show("Message cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            // Step 5: Send the SMS
            PortCode.SendBulkSMS(phoneNumbers, messageText);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectPort_Click(object sender, EventArgs e)
        {

        }

        private void readData_Click(object sender, EventArgs e)
        {

        }

        private void btnSendSMS_Click_1(object sender, EventArgs e)
        {

        }
    }

}
