﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spectrum.Classes;

namespace Spectrum.Forms {
    public partial class SettingsForm : Form {

        SpectrumFormMain spectrumMain;

        SettingsHandler settingsHander;

        string activeProfile;

        bool settingsChanged = false;

        bool formReady = false;

        Dictionary<string, dynamic> tempSettings;
        public SettingsForm(SpectrumFormMain main, SettingsHandler settings) {
            spectrumMain = main;
            settingsHander = settings;
            InitializeComponent();
            
            // will be used later
            // MaximumSize = new Size(435, 295);
        }

        // builds settings form when shown
        private void SettingsForm_Shown(object sender, EventArgs e) {
            
            // since visual studio only using Shown once I needed to reasing this to Visablility changed event
            // this prevents code from running on close
            if (!Visible) return;

            buildProfiles();
            buildPorts();
            buildSettings();

            // creates a temp settings
            tempSettings = settingsHander.createSettings();
            settingsChanged = false;
            formReady = true;
        }

        public void buildProfiles() {
            int index = 0;
            profileComboBox.Items.Clear();
            foreach (string item in settingsHander.getSettingProfiles()) {
                if(item == "Default") {
                    continue;
                }
                // sets proper index for profile
                if (item == settingsHander.currentProfile)
                    index = profileComboBox.Items.Count;

                profileComboBox.Items.Add(item);
            }

            profileComboBox.SelectedIndex = index;
        }

        private void buildPorts() {
            portComboBox.Items.Clear();
            foreach(string i in spectrumMain.serialPortComboBox.Items) {
                portComboBox.Items.Add(i);
            }
            portComboBox.SelectedIndex = 0;

            portComboBox.Enabled = spectrumMain.serialPortComboBox.Enabled;

        }


        // builds settings for current profile
        private void buildSettings() {
            activeProfile = profileComboBox.SelectedItem.ToString();

            buildSettingsRecusion(this.Controls, this);

            Console.WriteLine("--------------------------------");
        }
        private void buildSettingsRecusion(Control.ControlCollection controls, Control parent) {
            // goes through controls
            foreach(Control item in controls) {
                // if item is control is a checkbox set it
                if(item is CheckBox) {
                    setCheckbox((CheckBox)item, (GroupBox)parent);
                    continue;
                }
                if(item is TextBox) {
                    item.Text = settingsHander.getSetting(parent.Text, item.Name, activeProfile);
                }
                if(item is ComboBox && parent.Name != "general") {
                    ComboBox combo = (ComboBox)item;
                    string comboText = settingsHander.getSetting(parent.Text, combo.Name, activeProfile);
                    if (comboText != combo.Text)
                        combo.SelectedText = comboText;
                }
                // recurisve call if no checkboxes
                buildSettingsRecusion(item.Controls, item);
            }
        }

        // sets checkboxes
        private void setCheckbox(CheckBox check, GroupBox parent) {
            bool val;

            val = settingsHander.getSetting(parent.Text, check.Name, activeProfile);

            check.Checked = val;

            Console.WriteLine(String.Format("{0} was set to {1}", check.Name, val));
        }

        private void refreshButton_Click(object sender, EventArgs e) { spectrumMain.refreshButton.PerformClick(); }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            Hide();
        }

        private void saveFileButton_Click(object sender, EventArgs e) {
            saveFileDialog1.InitialDirectory = logPath.Text;
            saveFileDialog1.ShowDialog();
            logPath.Text = saveFileDialog1.FileName;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e) {
            if(formReady)
                checkSettings();
        }

        private void checkSettings() {
            
            bool checkChanged = false;
            bool textChanged = false;
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>()) {
                if (checkChanged) {
                    break;
                }
                foreach (CheckBox checkbox in groupBox.Controls.OfType<CheckBox>()) {
                    // checks to see if report logs was checked
                    if (checkbox.Checked == true && checkbox.Name == "reportErrors") {
                        var r = MessageBox.Show("By Enabling This Feature you agree to crash reports and logs back to the developer.", "Enable Error Reporting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        // does nothing if user does not agree
                        if (r == DialogResult.Cancel) {
                            checkbox.Checked = false;
                        }
                    }
                    if (checkBoxHelper(checkbox)) {
                        checkChanged = true;
                        try {
                            tempSettings[activeProfile][groupBox.Name][checkbox.Name] = checkbox.Checked;
                        }
                        catch { /*DO NOTHING */ }
                        break;
                    }
                    else if(checkChanged) {
                        checkChanged = false;
                    }
                }
                foreach(TextBox textbox in groupBox.Controls.OfType<TextBox>()) {
                    if (textBoxHelper(textbox)){
                        textChanged = true;
                        try {
                            tempSettings[activeProfile][groupBox.Name][textbox.Name] = textbox.Text;
                        }
                        catch { /* DO NOTHING */ }
                        break;
                    }
                    else if (textChanged) {
                        textChanged = false;
                    }
                }
            }

            applyButton.Enabled = checkChanged || textChanged;
        }

        private bool checkBoxHelper(CheckBox checkbox) {
            return settingsHander.getSetting(checkbox.Parent.Text, checkbox.Name, activeProfile) != checkbox.Checked;
        }
        private bool textBoxHelper(TextBox textbox) {
            return settingsHander.getSetting(textbox.Parent.Text, textbox.Name, activeProfile) != textbox.Text; 
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            settingsChanged = false;
            applyButton.Enabled = false;
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (settingsChanged) finalizeSettings();
            Hide();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            finalizeSettings();
        }


        private void finalizeSettings() {
            settingsHander.settings = tempSettings;
            settingsHander.saveSettings();
            settingsChanged = false;
            applyButton.Enabled = false;
        }

        // sets the download location
        private void DownloadLocation_Click(object sender, EventArgs e) {
            folderBrowserDialog1.SelectedPath = downloadPath.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK) {
                downloadPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DownloadPath_TextChanged(object sender, EventArgs e) {
            if (downloadPath.Text != settingsHander.getSetting("Updates", "downloadPath", activeProfile))
                checkSettings();
        }
    }
}
