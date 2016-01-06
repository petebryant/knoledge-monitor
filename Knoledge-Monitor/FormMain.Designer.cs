﻿namespace Knoledge_Monitor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxNetwork = new System.Windows.Forms.ToolStripComboBox();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonStatus = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonInfo = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(1230, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.comboBoxNetwork,
            this.toolStripMenuItem1,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.networkToolStripMenuItem.Text = "&Network";
            // 
            // comboBoxNetwork
            // 
            this.comboBoxNetwork.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNetwork.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetwork.Enabled = false;
            this.comboBoxNetwork.Items.AddRange(new object[] {
            "TestNet",
            "Main"});
            this.comboBoxNetwork.Name = "comboBoxNetwork";
            this.comboBoxNetwork.Size = new System.Drawing.Size(121, 33);
            this.comboBoxNetwork.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetwork_SelectedIndexChanged);
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Checked = true;
            this.localToolStripMenuItem.CheckOnClick = true;
            this.localToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.localToolStripMenuItem.Enabled = false;
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.localToolStripMenuItem.Text = "&Local Connection";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Enabled = false;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus,
            this.buttonStatus,
            this.buttonInfo,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 779);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(1230, 30);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(1158, 25);
            this.labelStatus.Spring = true;
            this.labelStatus.Text = "Not connected...";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStatus
            // 
            this.buttonStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonStatus.Image = global::Knoledge_Monitor.Properties.Resources.network_wireless_none;
            this.buttonStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.ShowDropDownArrow = false;
            this.buttonStatus.Size = new System.Drawing.Size(20, 28);
            this.buttonStatus.Text = "Connected to 0 Nodes";
            this.buttonStatus.ToolTipText = "Connected to 0 Nodes";
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonInfo.Image = global::Knoledge_Monitor.Properties.Resources.dialog_question;
            this.buttonInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.ShowDropDownArrow = false;
            this.buttonInfo.Size = new System.Drawing.Size(20, 28);
            this.buttonInfo.Text = "No Blockchain Info.";
            this.buttonInfo.ToolTipText = "No Blockchain Info.";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(17, 25);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 33);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(1230, 746);
            this.textBox.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 809);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Knoledge Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripDropDownButton buttonStatus;
        private System.Windows.Forms.ToolStripDropDownButton buttonInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripComboBox comboBoxNetwork;
    }
}

