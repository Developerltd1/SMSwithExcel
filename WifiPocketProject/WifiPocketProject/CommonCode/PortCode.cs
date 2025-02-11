using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiPocketProject.CommonCode
{
    public class PortCode
    {
        public void LoadSerialPortsIntoComboBox(ComboBox comboBoxPorts, Label lblConnectedPort)
        {
            try
            {
                comboBoxPorts.Items.Clear(); // Clear previous entries
                int portCount = 0; // Track total ports

                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        string name = obj["Name"]?.ToString();
                        if (!string.IsNullOrEmpty(name)) // Ensure valid data
                        {
                            comboBoxPorts.Items.Add(name);
                            portCount++;
                        }
                    }
                }

                if (portCount > 0)
                {
                    comboBoxPorts.SelectedIndex = 0; // Select first item
                    if (lblConnectedPort != null)
                        lblConnectedPort.Text = portCount.ToString();
                }
                else
                {
                    MessageBox.Show("No COM ports detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show($"Error accessing COM ports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Check if a valid port is connected
        public static bool IsPortConnected()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string name = obj["Name"]?.ToString();
                    if (!string.IsNullOrEmpty(name) && name.Contains("3G PC UI Interface"))
                    {
                        return true; // Valid port found
                    }
                }
            }
            return false; // No valid port found
        }

        // Get the first available COM port
        public static string GetAvailablePort()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string name = obj["Name"]?.ToString();
                    if (!string.IsNullOrEmpty(name) && name.Contains("3G PC UI Interface"))
                    {
                        return name.Split('(')[1].Replace(")", ""); // Extract COM port name
                    }
                }
            }
            return null; // No valid port found
        }

        // Send SMS via Serial Port
        //public static void SendMultipleSMS(List<string> phoneNumbers, string messageText)
        //{
        //    try
        //    {
        //        string availablePort = GetAvailablePort();
        //        if (string.IsNullOrEmpty(availablePort))
        //        {
        //            MessageBox.Show("No valid COM port detected. Ensure a '3G PC UI Interface' device is connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        using (SerialPort serialPort = new SerialPort(availablePort, 9600, Parity.None, 8, StopBits.One))
        //        {
        //            serialPort.Open();

        //            // Read and clear any existing data
        //            serialPort.DiscardInBuffer();
        //            serialPort.DiscardOutBuffer();

        //            // Set SMS text mode
        //            serialPort.WriteLine("AT+CMGF=1\r");
        //            Thread.Sleep(1000);

        //            if (!CheckResponse(serialPort, "OK"))
        //            {
        //                MessageBox.Show("Failed to set text mode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            // Ensure both lists have the same count
        //            int count = Math.Min(phoneNumbers.Count, messages.Count);

        //            for (int i = 0; i < count; i++)
        //            {
        //                string phoneNumber = phoneNumbers[i];
        //                string messageText = messages[i];

        //                // Send AT command with recipient phone number
        //                serialPort.WriteLine($"AT+CMGS=\"{phoneNumber}\"\r");
        //                Thread.Sleep(1000);

        //                if (!CheckResponse(serialPort, ">")) // Expecting '>' for message input
        //                {
        //                    Console.WriteLine($"Failed to set recipient number for {phoneNumber}");
        //                    continue;
        //                }

        //                // Send SMS message text
        //                serialPort.WriteLine(messageText + "\x1A"); // CTRL+Z to send
        //                Thread.Sleep(5000); // Give modem time to send message

        //                // Step 4: Check if SMS was sent successfully
        //                if (CheckResponse(serialPort, "OK"))
        //                {
        //                    Console.WriteLine($"SMS sent to {phoneNumber} successfully!");
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Failed to send SMS to {phoneNumber}!");
        //                }

        //                Thread.Sleep(2000); // Short delay before sending next SMS to avoid modem overload
        //            }

        //            serialPort.Close();
        //            MessageBox.Show("All SMS messages have been sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Failed to send SMS: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private static bool CheckResponse(SerialPort serialPort, string expectedResponse, int timeout = 5000)
        {
            int elapsedTime = 0;
            while (elapsedTime < timeout)
            {
                string response = serialPort.ReadExisting();
                if (!string.IsNullOrEmpty(response) && response.Contains(expectedResponse))
                {
                    return true; // Success
                }

                Thread.Sleep(500); // Wait 500ms before checking again
                elapsedTime += 500;
            }

            return false; // Timeout
        }


        #region DynamicResponse
        public static void SendBulkSMS(List<string> phoneNumbers, string messageText)
        {
            try
            {
                string availablePort = GetAvailablePort();
                if (string.IsNullOrEmpty(availablePort))
                {
                    MessageBox.Show("No valid COM port detected. Ensure a '3G PC UI Interface' device is connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SerialPort serialPort = new SerialPort(availablePort, 9600, Parity.None, 8, StopBits.One))
                {
                    if (!serialPort.IsOpen)
                    {
                        serialPort.Open();
                        Thread.Sleep(1000); // Allow modem to initialize
                    }
                    serialPort.DiscardInBuffer();
                    serialPort.DiscardOutBuffer();

                    ////serialPort.WriteLine("ATZ\r"); // Reset modem
                    ////Thread.Sleep(1000);

                    // Set SMS text mode
                    serialPort.WriteLine("AT+CMGF=1\r");
                    Thread.Sleep(500);
                    if (!CheckResponse(serialPort, "OK"))
                    {
                        MessageBox.Show("Failed to set text mode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int baseDelay = 500; // Initial delay in milliseconds
                    int index = 0;
                    foreach (string phoneNumber in phoneNumbers)
                    {
                        bool smsSent = false;
                        int retries = 0;

                        while (!smsSent && retries < 3) // Retry up to 3 times
                        {
                            serialPort.WriteLine($"AT+CMGS=\"{phoneNumber}\"\r");
                            Thread.Sleep(500);

                            if (!CheckResponse(serialPort, ">")) // Expecting '>' for message input
                            {
                                retries++;
                                baseDelay = Math.Min(baseDelay + 500, 2000); // Increase delay on failure
                                continue;
                            }

                            serialPort.WriteLine(messageText+": " +index + "\x1A"); // CTRL+Z to send
                            Thread.Sleep(5000); // Dynamic delay
                            //Thread.Sleep(baseDelay); // Dynamic delay
                            index++;
                            if (CheckResponse(serialPort, "OK"))
                            {
                              //  MessageBox.Show($"SMS sent successfully to {phoneNumber}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                smsSent = true;
                                baseDelay = Math.Max(baseDelay - 100, 200); // Decrease delay on success
                            }
                            else
                            {
                                retries++;
                                baseDelay = Math.Min(baseDelay + 500, 2000); // Increase delay on failure
                            }
                        }

                        if (!smsSent)
                        {
                            MessageBox.Show($"Failed to send SMS to {phoneNumber} after 3 attempts. Count: " + index, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        }
                    }

                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send SMS: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion
    }
}
