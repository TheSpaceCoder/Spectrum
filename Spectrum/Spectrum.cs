﻿using Microsoft.Win32;
using Spectrum.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spectrum {

    public partial class spectrumFormMain : Form {

        // Variables
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //Boolin
        bool exitFromTray = false;

        // Forms
        spectrumFormMain spectrumForm;
        SettingsForm settingsForm;


        // In The Begining...
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public spectrumFormMain() {
            InitializeComponent();
            
            listSerialPorts();
            
            // Sets Current Form | Used for Context Menu
            spectrumForm = this;
            settingsForm = new SettingsForm();
            if (Settings.Default.connectOnStartupBool) Settings.Default.isConnected = true;
            else Settings.Default.isConnected = false;
            if (!Settings.Default.isConnected) startupConnectCheckBox.Enabled = false;
            
            

            redValue.Value = Settings.Default.redColor;
            greenValue.Value = Settings.Default.greenColor;
            blueValue.Value = Settings.Default.blueColor;

        }

        // On Form Load
        private void spectrumFormMain_Load(object sender, EventArgs e) {
            if (Settings.Default.connectOnStartupBool && Settings.Default.port != "") {
                serialPort1.PortName = Settings.Default.port;
                portConnect(true);
            }
            buttonEnable();
        }
        
        // On Form Close
        private void spectrumFormMain_FormClosing(object sender, FormClosingEventArgs e) {
            // Close App To Tray
            if (Settings.Default.closeToTrayBool && !exitFromTray) {
                e.Cancel = true;
                Hide();
            }
        }

        // Open From Tray
        private void spectrumTrayItem_DoubleClick(object sender, EventArgs e) {
            Show();
        }

        // Connects to Port
        private void portConnectButton_Click(object sender, EventArgs e) {
            
            try {
                //if (serialPort1.IsOpen) portConnect(false);
                if (!Settings.Default.isConnected) portConnect(true);
                else portConnect(false);
            }
            catch {
                MessageBox.Show("Could not connect please make sure the arduino is plugged in and that you have selected the correct port", "Could Not Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sets Solid Color
        private void solidColorButton_Click(object sender, EventArgs e) {

            var red = redValue.Value.ToString();
            var green = greenValue.Value.ToString();
            var blue = blueValue.Value.ToString();

            // Red Value Hotfix
            if (redValue.Value < 10) red = "00" + red; if (redValue.Value >= 10 && redValue.Value < 100) red = "0" + red;
            // Green Value Hotfix
            if (greenValue.Value < 10) green = "00" + green; if (greenValue.Value >= 10 && greenValue.Value < 100) green = "0" + green;
            // Blue Value Hotfix
            if (blueValue.Value < 10) blue = "00" + blue; if (blueValue.Value >= 10 && blueValue.Value < 100) blue = "0" + blue;

            serialPort1.WriteLine("SolidColor" + red + green + blue);
            Console.WriteLine("SolidColor"+red + green + blue);
        }

        // Rainbow Animation Button
        private void rainbowButton_Click(object sender, EventArgs e) {
            var delay = delayValue.Value.ToString();
            serialPort1.WriteLine("Rainbow" + delay);
            Console.WriteLine("Rainbow" + delay);
        }



        // CUSTOM FUNCTIONS
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Lists Serial Ports for Combobox and Debugging
        private void listSerialPorts() {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports) {
                Console.WriteLine(port);
                serialComboBox.Items.Add(port);
            }
            
            // Sets Combo Box to First COM Port
            serialComboBox.SelectedIndex = 0;
        }

        // Port Connect/Disconnect
        private void portConnect(bool open) {
            string port = serialComboBox.SelectedItem.ToString();
            if (open) {
                serialPort1.PortName = port;
                serialPort1.Open();
                Console.WriteLine("Connected to port: " + serialPort1.PortName);
                //MessageBox.Show("Connected to: " + port, "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connectedStatusLabel.Text = "Connected";
                connectedStatusLabel.BackColor = Color.Green;
                portConnectButton.Text = "Disconnect";
                Settings.Default.isConnected = true;
                settingsForm.startupConnectCheckBox.Enabled = true;
                Settings.Default.port = port;
            }
            else {
                serialPort1.Close();
                connectedStatusLabel.Text = "Not Connected";
                connectedStatusLabel.BackColor = Color.Red;
                portConnectButton.Text = "Connect";
                Settings.Default.isConnected = false;
                settingsForm.startupConnectCheckBox.Enabled = false;
            }
            buttonEnable();
        }

        // Enables/Disables Buttons
        private void buttonEnable() {
            if (Settings.Default.isConnected) {
                solidColorButton.Enabled = true;
                rainbowButton.Enabled = true;
            }
            else {
                solidColorButton.Enabled = false;
                rainbowButton.Enabled = false;
            }
        }



        // CHECKBOX SETTINGS -- WILL BE MOVING TO ANOTHER FORM SOON
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void settingsCheckboxes_CheckedChanged(object sender, EventArgs e) {
            if (Settings.Default.connectOnStartupBool != startupConnectCheckBox.Checked) {
                applySettingsButton.Enabled = true;
            }
            else if (Settings.Default.closeToTrayBool != closeToTrayCheckbox.Checked) {
                applySettingsButton.Enabled = true;
            }
            else if (Settings.Default.windowsStartupBool != windowsCheckbox.Checked) {
                applySettingsButton.Enabled = true;
            }
            else applySettingsButton.Enabled = false;
        }


        // Apply Settings Button
        private void applySettingsButton_Click(object sender, EventArgs e) {

            // Connect at Startup Settings
            if (startupConnectCheckBox.Checked) Settings.Default.connectOnStartupBool = true;
            else Settings.Default.connectOnStartupBool = false;

            // Close to Tray Settings
            if (closeToTrayCheckbox.Checked) Settings.Default.closeToTrayBool = true;
            else Settings.Default.closeToTrayBool = false;

            // Start With Windows
            if (windowsCheckbox.Checked) {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                    key.SetValue("Spectrum", "\"" + Application.ExecutablePath + "\"");
                    Settings.Default.windowsStartupBool = true;
                }
            }
            else {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                    key.DeleteValue("Spectrum", false);
                    Settings.Default.windowsStartupBool = false;
                }
            }

            Settings.Default.Save();
            applySettingsButton.Enabled = false;
        }


        // MENU BAR SETTINGS
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Save Settings
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {

            Settings.Default.redColor = (int)redValue.Value;
            Settings.Default.greenColor = (int)greenValue.Value;
            Settings.Default.blueColor = (int)blueValue.Value;

            Settings.Default.Save();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        // Link to Documentation
        private void documentationToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Documentation is not ready at this time");
        }

        // Reset Settings
        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e) {


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset all your settings?", "RESET SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                try {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                        key.DeleteValue("Spectrum", false);
                    }
                }
                finally {Settings.Default.Reset();}
                
            }


        }

        // Link to Github
        private void githubToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/DeanSellas/Spectrum");
        }

        // Donate Button
        private void donateToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=RVNJATCSR7FGC&lc=US&item_name=Specturm%20Donation&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted");
        }



        // CONTEXT MENU
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Defines Context Menu Options
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            if (Settings.Default.isConnected) connectToolStripMenuItem.Text = "Disconnect"; else connectToolStripMenuItem.Text = "Connect";
            if (spectrumForm.Visible) showToolStripMenuItem.Text = "Hide"; else showToolStripMenuItem.Text = "Show";
        }

        // Context Menu Connect/Disconnect
        private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Settings.Default.isConnected) portConnect(false); else portConnect(true);
        }
        // Context Menu Show/Hide
        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            if (spectrumForm.Visible) Hide(); else Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            exitFromTray = true;
            Close();
        }

        
    }



    // THE END
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
