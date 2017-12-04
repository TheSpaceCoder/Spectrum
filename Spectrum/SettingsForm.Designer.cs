﻿namespace Spectrum {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Arduino");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Updates");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Advnaced");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.applySettingsButton = new System.Windows.Forms.Button();
            this.windowsCheckbox = new System.Windows.Forms.CheckBox();
            this.startupConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.closeToTrayCheckbox = new System.Windows.Forms.CheckBox();
            this.startMinCheckbox = new System.Windows.Forms.CheckBox();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.generalSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultSettingsButton = new System.Windows.Forms.Button();
            this.offOnClose = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.updatesGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultLocationButton = new System.Windows.Forms.Button();
            this.fileExplorerButton = new System.Windows.Forms.Button();
            this.fileExplorerTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.arduinoSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.rememberLightCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stripLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.defaultPortComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.advancedSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.devBuildsCheckbox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.generalSettingsGroupBox.SuspendLayout();
            this.updatesGroupBox.SuspendLayout();
            this.arduinoSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stripLengthUpDown)).BeginInit();
            this.advancedSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Enabled = false;
            this.applySettingsButton.Location = new System.Drawing.Point(583, 631);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(79, 23);
            this.applySettingsButton.TabIndex = 18;
            this.applySettingsButton.Tag = "";
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.applySettingsButton_Click);
            // 
            // windowsCheckbox
            // 
            this.windowsCheckbox.AutoSize = true;
            this.windowsCheckbox.Location = new System.Drawing.Point(80, 99);
            this.windowsCheckbox.Name = "windowsCheckbox";
            this.windowsCheckbox.Size = new System.Drawing.Size(120, 17);
            this.windowsCheckbox.TabIndex = 17;
            this.windowsCheckbox.Tag = "";
            this.windowsCheckbox.Text = "Start With Windows";
            this.windowsCheckbox.UseVisualStyleBackColor = true;
            this.windowsCheckbox.CheckedChanged += new System.EventHandler(this.settingsCheckboxes_CheckedChanged);
            // 
            // startupConnectCheckBox
            // 
            this.startupConnectCheckBox.AutoSize = true;
            this.startupConnectCheckBox.Enabled = false;
            this.startupConnectCheckBox.Location = new System.Drawing.Point(80, 33);
            this.startupConnectCheckBox.Name = "startupConnectCheckBox";
            this.startupConnectCheckBox.Size = new System.Drawing.Size(120, 17);
            this.startupConnectCheckBox.TabIndex = 16;
            this.startupConnectCheckBox.Tag = "";
            this.startupConnectCheckBox.Text = "Connect On Startup";
            this.startupConnectCheckBox.UseVisualStyleBackColor = true;
            this.startupConnectCheckBox.CheckedChanged += new System.EventHandler(this.settingsCheckboxes_CheckedChanged);
            // 
            // closeToTrayCheckbox
            // 
            this.closeToTrayCheckbox.AutoSize = true;
            this.closeToTrayCheckbox.Location = new System.Drawing.Point(80, 56);
            this.closeToTrayCheckbox.Name = "closeToTrayCheckbox";
            this.closeToTrayCheckbox.Size = new System.Drawing.Size(92, 17);
            this.closeToTrayCheckbox.TabIndex = 15;
            this.closeToTrayCheckbox.Tag = "";
            this.closeToTrayCheckbox.Text = "Close To Tray";
            this.closeToTrayCheckbox.UseVisualStyleBackColor = true;
            this.closeToTrayCheckbox.CheckedChanged += new System.EventHandler(this.settingsCheckboxes_CheckedChanged);
            // 
            // startMinCheckbox
            // 
            this.startMinCheckbox.AutoSize = true;
            this.startMinCheckbox.Location = new System.Drawing.Point(80, 79);
            this.startMinCheckbox.Name = "startMinCheckbox";
            this.startMinCheckbox.Size = new System.Drawing.Size(97, 17);
            this.startMinCheckbox.TabIndex = 19;
            this.startMinCheckbox.Tag = "";
            this.startMinCheckbox.Text = "Start Minimized";
            this.startMinCheckbox.UseVisualStyleBackColor = true;
            this.startMinCheckbox.CheckedChanged += new System.EventHandler(this.settingsCheckboxes_CheckedChanged);
            // 
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Items.AddRange(new object[] {
            "Never",
            "On Startup",
            "On Startup Daily",
            "On Startup Weekly",
            "On Startup Monthly"});
            this.updateComboBox.Location = new System.Drawing.Point(120, 64);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(117, 21);
            this.updateComboBox.TabIndex = 20;
            this.updateComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Check Updates Every:";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Indent = 10;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(1, 42);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "generalNode";
            treeNode1.Text = "General";
            treeNode2.Name = "arduinoNode";
            treeNode2.Text = "Arduino";
            treeNode3.Name = "updatesNode";
            treeNode3.Text = "Updates";
            treeNode4.Name = "advancedNode";
            treeNode4.Text = "Advnaced";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView1.Size = new System.Drawing.Size(75, 198);
            this.treeView1.TabIndex = 22;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // generalSettingsGroupBox
            // 
            this.generalSettingsGroupBox.Controls.Add(this.startupConnectCheckBox);
            this.generalSettingsGroupBox.Controls.Add(this.closeToTrayCheckbox);
            this.generalSettingsGroupBox.Controls.Add(this.windowsCheckbox);
            this.generalSettingsGroupBox.Controls.Add(this.startMinCheckbox);
            this.generalSettingsGroupBox.Location = new System.Drawing.Point(82, 34);
            this.generalSettingsGroupBox.Name = "generalSettingsGroupBox";
            this.generalSettingsGroupBox.Size = new System.Drawing.Size(257, 208);
            this.generalSettingsGroupBox.TabIndex = 23;
            this.generalSettingsGroupBox.TabStop = false;
            this.generalSettingsGroupBox.Text = "General Settings";
            this.generalSettingsGroupBox.Visible = false;
            // 
            // defaultSettingsButton
            // 
            this.defaultSettingsButton.Location = new System.Drawing.Point(83, 38);
            this.defaultSettingsButton.Name = "defaultSettingsButton";
            this.defaultSettingsButton.Size = new System.Drawing.Size(97, 23);
            this.defaultSettingsButton.TabIndex = 20;
            this.defaultSettingsButton.Text = "Default Settings";
            this.toolTip1.SetToolTip(this.defaultSettingsButton, "Reset Settings To Default");
            this.defaultSettingsButton.UseVisualStyleBackColor = true;
            this.defaultSettingsButton.Click += new System.EventHandler(this.defaultSettingsButton_Click);
            // 
            // offOnClose
            // 
            this.offOnClose.AutoSize = true;
            this.offOnClose.Location = new System.Drawing.Point(80, 134);
            this.offOnClose.Name = "offOnClose";
            this.offOnClose.Size = new System.Drawing.Size(111, 17);
            this.offOnClose.TabIndex = 20;
            this.offOnClose.Text = "Turn Off On Close";
            this.toolTip1.SetToolTip(this.offOnClose, "Turn off the Neopixels when Spectrum closes");
            this.offOnClose.UseVisualStyleBackColor = true;
            this.offOnClose.CheckedChanged += new System.EventHandler(this.settingsCheckboxes_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(498, 631);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 23);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Tag = "";
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(413, 631);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(79, 23);
            this.okButton.TabIndex = 25;
            this.okButton.Tag = "";
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // updatesGroupBox
            // 
            this.updatesGroupBox.Controls.Add(this.label2);
            this.updatesGroupBox.Controls.Add(this.defaultLocationButton);
            this.updatesGroupBox.Controls.Add(this.fileExplorerButton);
            this.updatesGroupBox.Controls.Add(this.fileExplorerTextBox);
            this.updatesGroupBox.Controls.Add(this.updateComboBox);
            this.updatesGroupBox.Controls.Add(this.label1);
            this.updatesGroupBox.Location = new System.Drawing.Point(381, 34);
            this.updatesGroupBox.Name = "updatesGroupBox";
            this.updatesGroupBox.Size = new System.Drawing.Size(257, 208);
            this.updatesGroupBox.TabIndex = 22;
            this.updatesGroupBox.TabStop = false;
            this.updatesGroupBox.Text = "Updates Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Download Location:";
            // 
            // defaultLocationButton
            // 
            this.defaultLocationButton.Location = new System.Drawing.Point(58, 149);
            this.defaultLocationButton.Name = "defaultLocationButton";
            this.defaultLocationButton.Size = new System.Drawing.Size(108, 23);
            this.defaultLocationButton.TabIndex = 24;
            this.defaultLocationButton.Text = "Default Location";
            this.defaultLocationButton.UseVisualStyleBackColor = true;
            this.defaultLocationButton.Click += new System.EventHandler(this.defaultLocationButton_Click);
            // 
            // fileExplorerButton
            // 
            this.fileExplorerButton.Location = new System.Drawing.Point(215, 121);
            this.fileExplorerButton.Name = "fileExplorerButton";
            this.fileExplorerButton.Size = new System.Drawing.Size(42, 23);
            this.fileExplorerButton.TabIndex = 23;
            this.fileExplorerButton.Text = "...";
            this.fileExplorerButton.UseVisualStyleBackColor = true;
            this.fileExplorerButton.Click += new System.EventHandler(this.fileExplorerButton_Click);
            // 
            // fileExplorerTextBox
            // 
            this.fileExplorerTextBox.Location = new System.Drawing.Point(9, 123);
            this.fileExplorerTextBox.Name = "fileExplorerTextBox";
            this.fileExplorerTextBox.Size = new System.Drawing.Size(200, 20);
            this.fileExplorerTextBox.TabIndex = 22;
            this.fileExplorerTextBox.TextChanged += new System.EventHandler(this.fileExplorerTextBox_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // arduinoSettingsGroupBox
            // 
            this.arduinoSettingsGroupBox.Controls.Add(this.rememberLightCheckbox);
            this.arduinoSettingsGroupBox.Controls.Add(this.label4);
            this.arduinoSettingsGroupBox.Controls.Add(this.stripLengthUpDown);
            this.arduinoSettingsGroupBox.Controls.Add(this.offOnClose);
            this.arduinoSettingsGroupBox.Controls.Add(this.defaultPortComboBox);
            this.arduinoSettingsGroupBox.Controls.Add(this.label3);
            this.arduinoSettingsGroupBox.Location = new System.Drawing.Point(82, 248);
            this.arduinoSettingsGroupBox.Name = "arduinoSettingsGroupBox";
            this.arduinoSettingsGroupBox.Size = new System.Drawing.Size(257, 208);
            this.arduinoSettingsGroupBox.TabIndex = 24;
            this.arduinoSettingsGroupBox.TabStop = false;
            this.arduinoSettingsGroupBox.Text = "Arduino Settings";
            this.arduinoSettingsGroupBox.Visible = false;
            // 
            // rememberLightCheckbox
            // 
            this.rememberLightCheckbox.AutoSize = true;
            this.rememberLightCheckbox.Location = new System.Drawing.Point(80, 157);
            this.rememberLightCheckbox.Name = "rememberLightCheckbox";
            this.rememberLightCheckbox.Size = new System.Drawing.Size(149, 17);
            this.rememberLightCheckbox.TabIndex = 26;
            this.rememberLightCheckbox.Text = "Remember Lighting Profile";
            this.toolTip1.SetToolTip(this.rememberLightCheckbox, "Sends last known lighting profile to the Arduino when Spectrum startsup.");
            this.rememberLightCheckbox.UseVisualStyleBackColor = true;
            this.rememberLightCheckbox.CheckedChanged += new System.EventHandler(this.settingsCheckboxes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "NeoPixel Strip Length:";
            // 
            // stripLengthUpDown
            // 
            this.stripLengthUpDown.Location = new System.Drawing.Point(138, 95);
            this.stripLengthUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stripLengthUpDown.Name = "stripLengthUpDown";
            this.stripLengthUpDown.Size = new System.Drawing.Size(76, 20);
            this.stripLengthUpDown.TabIndex = 24;
            this.toolTip1.SetToolTip(this.stripLengthUpDown, "Amount of Neopixels connected to the Arduino");
            this.stripLengthUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stripLengthUpDown.ValueChanged += new System.EventHandler(this.stripLengthUpDown_ValueChanged);
            this.stripLengthUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stripLengthUpDown_KeyDown);
            // 
            // defaultPortComboBox
            // 
            this.defaultPortComboBox.FormattingEnabled = true;
            this.defaultPortComboBox.Location = new System.Drawing.Point(119, 45);
            this.defaultPortComboBox.Name = "defaultPortComboBox";
            this.defaultPortComboBox.Size = new System.Drawing.Size(117, 21);
            this.defaultPortComboBox.TabIndex = 22;
            this.toolTip1.SetToolTip(this.defaultPortComboBox, "COM Port Arduino is connected to");
            this.defaultPortComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Default COM Port:";
            // 
            // advancedSettingsGroupBox
            // 
            this.advancedSettingsGroupBox.Controls.Add(this.label5);
            this.advancedSettingsGroupBox.Controls.Add(this.devBuildsCheckbox);
            this.advancedSettingsGroupBox.Controls.Add(this.defaultSettingsButton);
            this.advancedSettingsGroupBox.Location = new System.Drawing.Point(381, 248);
            this.advancedSettingsGroupBox.Name = "advancedSettingsGroupBox";
            this.advancedSettingsGroupBox.Size = new System.Drawing.Size(257, 208);
            this.advancedSettingsGroupBox.TabIndex = 27;
            this.advancedSettingsGroupBox.TabStop = false;
            this.advancedSettingsGroupBox.Text = "Advanced Settings";
            this.advancedSettingsGroupBox.Visible = false;
            // 
            // devBuildsCheckbox
            // 
            this.devBuildsCheckbox.AutoSize = true;
            this.devBuildsCheckbox.Enabled = false;
            this.devBuildsCheckbox.Location = new System.Drawing.Point(83, 92);
            this.devBuildsCheckbox.Name = "devBuildsCheckbox";
            this.devBuildsCheckbox.Size = new System.Drawing.Size(113, 17);
            this.devBuildsCheckbox.TabIndex = 21;
            this.devBuildsCheckbox.Text = "Enable Dev Builds";
            this.toolTip1.SetToolTip(this.devBuildsCheckbox, "Feature Currently Not Avalible");
            this.devBuildsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "This feature is currently not avalible";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 666);
            this.Controls.Add(this.advancedSettingsGroupBox);
            this.Controls.Add(this.arduinoSettingsGroupBox);
            this.Controls.Add(this.updatesGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.generalSettingsGroupBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.applySettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.generalSettingsGroupBox.ResumeLayout(false);
            this.generalSettingsGroupBox.PerformLayout();
            this.updatesGroupBox.ResumeLayout(false);
            this.updatesGroupBox.PerformLayout();
            this.arduinoSettingsGroupBox.ResumeLayout(false);
            this.arduinoSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stripLengthUpDown)).EndInit();
            this.advancedSettingsGroupBox.ResumeLayout(false);
            this.advancedSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applySettingsButton;
        private System.Windows.Forms.CheckBox windowsCheckbox;
        private System.Windows.Forms.CheckBox closeToTrayCheckbox;
        public System.Windows.Forms.CheckBox startupConnectCheckBox;
        private System.Windows.Forms.CheckBox startMinCheckbox;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox generalSettingsGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox updatesGroupBox;
        private System.Windows.Forms.CheckBox offOnClose;
        private System.Windows.Forms.Button fileExplorerButton;
        private System.Windows.Forms.TextBox fileExplorerTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button defaultLocationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox arduinoSettingsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown stripLengthUpDown;
        public System.Windows.Forms.ComboBox defaultPortComboBox;
        private System.Windows.Forms.CheckBox rememberLightCheckbox;
        private System.Windows.Forms.Button defaultSettingsButton;
        private System.Windows.Forms.GroupBox advancedSettingsGroupBox;
        private System.Windows.Forms.CheckBox devBuildsCheckbox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
    }
}