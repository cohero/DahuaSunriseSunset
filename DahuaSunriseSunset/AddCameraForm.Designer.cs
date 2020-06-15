﻿namespace DahuaSunriseSunset
{
	partial class AddCameraForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHostAndPort = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbHttps = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDayZoom = new System.Windows.Forms.TextBox();
			this.txtDayFocus = new System.Windows.Forms.TextBox();
			this.txtNightFocus = new System.Windows.Forms.TextBox();
			this.txtNightZoom = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnGetCurrent = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.lblLensCmd = new System.Windows.Forms.Label();
			this.nudLensCmdDelay = new System.Windows.Forms.NumericUpDown();
			this.lblLensCmdQ = new System.Windows.Forms.LinkLabel();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cbSunriseProfile = new System.Windows.Forms.ComboBox();
			this.cbSunsetProfile = new System.Windows.Forms.ComboBox();
			this.lblMultiSensorQ = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblMultiSensorHelp = new System.Windows.Forms.LinkLabel();
			this.txtChannelNumbers = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudLensCmdDelay)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host name and port number";
			this.toolTip1.SetToolTip(this.label1, "e.g. \"127.0.0.1:8080\"");
			// 
			// txtHostAndPort
			// 
			this.txtHostAndPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHostAndPort.Location = new System.Drawing.Point(15, 25);
			this.txtHostAndPort.Name = "txtHostAndPort";
			this.txtHostAndPort.Size = new System.Drawing.Size(248, 20);
			this.txtHostAndPort.TabIndex = 1;
			this.txtHostAndPort.Text = "127.0.0.1:8080";
			this.toolTip1.SetToolTip(this.txtHostAndPort, "e.g. \"127.0.0.1:8080\"");
			// 
			// txtUser
			// 
			this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUser.Location = new System.Drawing.Point(15, 64);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(248, 20);
			this.txtUser.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "User Name";
			// 
			// txtPass
			// 
			this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPass.Location = new System.Drawing.Point(15, 103);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(248, 20);
			this.txtPass.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password";
			// 
			// cbHttps
			// 
			this.cbHttps.AutoSize = true;
			this.cbHttps.Location = new System.Drawing.Point(15, 129);
			this.cbHttps.Name = "cbHttps";
			this.cbHttps.Size = new System.Drawing.Size(146, 17);
			this.cbHttps.TabIndex = 7;
			this.cbHttps.Text = "Use https:// (secure http)";
			this.cbHttps.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(278, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Day Zoom";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(278, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Day Focus";
			// 
			// txtDayZoom
			// 
			this.txtDayZoom.Location = new System.Drawing.Point(281, 25);
			this.txtDayZoom.Name = "txtDayZoom";
			this.txtDayZoom.Size = new System.Drawing.Size(287, 20);
			this.txtDayZoom.TabIndex = 15;
			// 
			// txtDayFocus
			// 
			this.txtDayFocus.Location = new System.Drawing.Point(281, 73);
			this.txtDayFocus.Name = "txtDayFocus";
			this.txtDayFocus.Size = new System.Drawing.Size(287, 20);
			this.txtDayFocus.TabIndex = 17;
			// 
			// txtNightFocus
			// 
			this.txtNightFocus.Location = new System.Drawing.Point(281, 174);
			this.txtNightFocus.Name = "txtNightFocus";
			this.txtNightFocus.Size = new System.Drawing.Size(287, 20);
			this.txtNightFocus.TabIndex = 21;
			// 
			// txtNightZoom
			// 
			this.txtNightZoom.Location = new System.Drawing.Point(281, 126);
			this.txtNightZoom.Name = "txtNightZoom";
			this.txtNightZoom.Size = new System.Drawing.Size(287, 20);
			this.txtNightZoom.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(278, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Night Focus";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(278, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Night Zoom";
			// 
			// btnGetCurrent
			// 
			this.btnGetCurrent.Location = new System.Drawing.Point(281, 236);
			this.btnGetCurrent.Name = "btnGetCurrent";
			this.btnGetCurrent.Size = new System.Drawing.Size(179, 23);
			this.btnGetCurrent.TabIndex = 27;
			this.btnGetCurrent.Text = "Get Current Zoom/Focus";
			this.btnGetCurrent.UseVisualStyleBackColor = true;
			this.btnGetCurrent.Click += new System.EventHandler(this.btnGetCurrent_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(466, 236);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(102, 23);
			this.btnHelp.TabIndex = 29;
			this.btnHelp.Text = "Help!";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// lblLensCmd
			// 
			this.lblLensCmd.AutoSize = true;
			this.lblLensCmd.Cursor = System.Windows.Forms.Cursors.Help;
			this.lblLensCmd.Location = new System.Drawing.Point(278, 202);
			this.lblLensCmd.Name = "lblLensCmd";
			this.lblLensCmd.Size = new System.Drawing.Size(175, 13);
			this.lblLensCmd.TabIndex = 20;
			this.lblLensCmd.Text = "Seconds Between Lens Commands";
			this.lblLensCmd.Click += new System.EventHandler(this.lblLensCmd_Click);
			// 
			// nudLensCmdDelay
			// 
			this.nudLensCmdDelay.BackColor = System.Drawing.SystemColors.Window;
			this.nudLensCmdDelay.Location = new System.Drawing.Point(496, 200);
			this.nudLensCmdDelay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudLensCmdDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudLensCmdDelay.Name = "nudLensCmdDelay";
			this.nudLensCmdDelay.Size = new System.Drawing.Size(72, 20);
			this.nudLensCmdDelay.TabIndex = 25;
			this.nudLensCmdDelay.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// lblLensCmdQ
			// 
			this.lblLensCmdQ.AutoSize = true;
			this.lblLensCmdQ.Cursor = System.Windows.Forms.Cursors.Help;
			this.lblLensCmdQ.Location = new System.Drawing.Point(459, 202);
			this.lblLensCmdQ.Name = "lblLensCmdQ";
			this.lblLensCmdQ.Size = new System.Drawing.Size(13, 13);
			this.lblLensCmdQ.TabIndex = 23;
			this.lblLensCmdQ.TabStop = true;
			this.lblLensCmdQ.Text = "?";
			this.lblLensCmdQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLensCmdQ_LinkClicked);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 158);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "Sunrise Profile:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 191);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Sunset Profile:";
			// 
			// cbSunriseProfile
			// 
			this.cbSunriseProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSunriseProfile.FormattingEnabled = true;
			this.cbSunriseProfile.Location = new System.Drawing.Point(109, 155);
			this.cbSunriseProfile.Name = "cbSunriseProfile";
			this.cbSunriseProfile.Size = new System.Drawing.Size(154, 21);
			this.cbSunriseProfile.TabIndex = 9;
			// 
			// cbSunsetProfile
			// 
			this.cbSunsetProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSunsetProfile.FormattingEnabled = true;
			this.cbSunsetProfile.Location = new System.Drawing.Point(109, 188);
			this.cbSunsetProfile.Name = "cbSunsetProfile";
			this.cbSunsetProfile.Size = new System.Drawing.Size(154, 21);
			this.cbSunsetProfile.TabIndex = 11;
			// 
			// lblMultiSensorQ
			// 
			this.lblMultiSensorQ.AutoSize = true;
			this.lblMultiSensorQ.Cursor = System.Windows.Forms.Cursors.Help;
			this.lblMultiSensorQ.Location = new System.Drawing.Point(12, 220);
			this.lblMultiSensorQ.Name = "lblMultiSensorQ";
			this.lblMultiSensorQ.Size = new System.Drawing.Size(107, 13);
			this.lblMultiSensorQ.TabIndex = 27;
			this.lblMultiSensorQ.Text = "Multi-sensor camera?";
			this.lblMultiSensorQ.Click += new System.EventHandler(this.lblMultiSensorQ_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 241);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(94, 13);
			this.label11.TabIndex = 28;
			this.label11.Text = "Channel Numbers:";
			// 
			// lblMultiSensorHelp
			// 
			this.lblMultiSensorHelp.AutoSize = true;
			this.lblMultiSensorHelp.Cursor = System.Windows.Forms.Cursors.Help;
			this.lblMultiSensorHelp.Location = new System.Drawing.Point(125, 220);
			this.lblMultiSensorHelp.Name = "lblMultiSensorHelp";
			this.lblMultiSensorHelp.Size = new System.Drawing.Size(62, 13);
			this.lblMultiSensorHelp.TabIndex = 12;
			this.lblMultiSensorHelp.TabStop = true;
			this.lblMultiSensorHelp.Text = "(learn more)";
			this.lblMultiSensorHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMultiSensorHelp_LinkClicked);
			// 
			// txtChannelNumbers
			// 
			this.txtChannelNumbers.Location = new System.Drawing.Point(109, 238);
			this.txtChannelNumbers.Name = "txtChannelNumbers";
			this.txtChannelNumbers.Size = new System.Drawing.Size(154, 20);
			this.txtChannelNumbers.TabIndex = 13;
			this.txtChannelNumbers.Text = "1";
			this.txtChannelNumbers.TextChanged += new System.EventHandler(this.txtChannelNumbers_TextChanged);
			// 
			// AddCameraForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 271);
			this.Controls.Add(this.txtChannelNumbers);
			this.Controls.Add(this.lblMultiSensorHelp);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lblMultiSensorQ);
			this.Controls.Add(this.cbSunsetProfile);
			this.Controls.Add(this.cbSunriseProfile);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblLensCmdQ);
			this.Controls.Add(this.nudLensCmdDelay);
			this.Controls.Add(this.lblLensCmd);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnGetCurrent);
			this.Controls.Add(this.txtNightFocus);
			this.Controls.Add(this.txtNightZoom);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDayFocus);
			this.Controls.Add(this.txtDayZoom);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbHttps);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtHostAndPort);
			this.Controls.Add(this.label1);
			this.Name = "AddCameraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Camera";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCameraForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.nudLensCmdDelay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtHostAndPort;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cbHttps;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDayZoom;
		private System.Windows.Forms.TextBox txtDayFocus;
		private System.Windows.Forms.TextBox txtNightFocus;
		private System.Windows.Forms.TextBox txtNightZoom;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnGetCurrent;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Label lblLensCmd;
		private System.Windows.Forms.NumericUpDown nudLensCmdDelay;
		private System.Windows.Forms.LinkLabel lblLensCmdQ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbSunriseProfile;
		private System.Windows.Forms.ComboBox cbSunsetProfile;
		private System.Windows.Forms.Label lblMultiSensorQ;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.LinkLabel lblMultiSensorHelp;
		private System.Windows.Forms.TextBox txtChannelNumbers;
	}
}