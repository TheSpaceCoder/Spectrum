﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spectrum.Classes;

namespace Spectrum {

    public partial class SpectrumFormMain : Form {
        SettingsHandler settingsHander;
        UpdateHandler updateHandler;

        public SpectrumFormMain() {
            settingsHander = new SettingsHandler();

            updateHandler = new UpdateHandler(settingsHander);

            Console.WriteLine("Current Profile: " + settingsHander.settingsProfile + "\n --------------------------------");

            // Prints Items in Settings
            foreach (string one in settingsHander.settings.Keys)
                foreach (string two in settingsHander.settings[one].Keys)
                    foreach (string three in settingsHander.settings[one][two].Keys)
                        Console.WriteLine("Profile: {0} -- Master: {1} -- Settings: {2} -- Value: {3}", one, two, three, settingsHander.settings[one][two][three]);
            Console.WriteLine("---Profiles Avaliable---");
            foreach(string profile in settingsHander.profileList) Console.WriteLine("Profile: {0}", profile);
            
            InitializeComponent();
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e) {
            updateHandler.checkForUpdate();
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/DeanSellas/Spectrum/wiki");
        }
        private void bugReportToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/DeanSellas/Spectrum/issues");
        }
        private void githubToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/DeanSellas/Spectrum");
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        
    }
}