﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DahuaSunriseSunset
{
	public partial class AddCameraForm : Form
	{
		public CameraDefinition newCamera;
		Color defaultChannelNumbersColor, defaultChannelNumbersBgColor;

		public AddCameraForm()
		{
			InitializeComponent();
			defaultChannelNumbersColor = txtChannelNumbers.ForeColor;
			defaultChannelNumbersBgColor = txtChannelNumbers.BackColor;
		}

		public void ConvertIntoEditForm(CameraDefinition existingCameraData)
		{
			newCamera = existingCameraData;
			txtHostAndPort.Text = newCamera.hostAndPort;
			txtUser.Text = newCamera.user;
			txtPass.Text = newCamera.pass;
			cbHttps.Checked = newCamera.https;
			txtDayZoom.Text = newCamera.dayZoom;
			txtDayFocus.Text = newCamera.dayFocus;
			txtNightZoom.Text = newCamera.nightZoom;
			txtNightFocus.Text = newCamera.nightFocus;
			nudLensCmdDelay.Value = newCamera.secondsBetweenLensCommands;

			txtChannelNumbers.Text = newCamera.channelNumbers;

			SetCbItems(cbSunriseProfile, Enum.GetNames(typeof(Profile)), newCamera.sunriseProfile);
			SetCbItems(cbSunsetProfile, Enum.GetNames(typeof(Profile)), newCamera.sunsetProfile);

			this.Text = "Edit Camera";
		}

		private void SetCbItems(ComboBox comboBox, string[] items, object selectedValue)
		{
			comboBox.Items.Clear();
			comboBox.Items.AddRange(items);
			string selectedItem = selectedValue.ToString();
			for (int i = 0; i < items.Length; i++)
				if (items[i] == selectedItem)
				{
					comboBox.SelectedIndex = i;
					break;
				}
		}
		private Profile GetSelectedProfile(ComboBox comboBox, Profile defaultValue)
		{
			int idx = comboBox.SelectedIndex;
			if (idx >= 0 && idx < comboBox.Items.Count)
			{
				if (Enum.TryParse<Profile>(comboBox.Items[idx].ToString(), out Profile profile))
					return profile;
			}
			return defaultValue;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGetCurrent_Click(object sender, EventArgs e)
		{
			WebClient wc = new WebClient();
			wc.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
			wc.DownloadStringCompleted += (sender2, e2) =>
			{
				TextMessageBox.Show(e2.Result);
			};
			wc.DownloadStringAsync(new Uri("http" + (cbHttps.Checked ? "s" : "") + "://" + txtHostAndPort.Text + "/cgi-bin/devVideoInput.cgi?action=getFocusStatus"));
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			new CameraHelpForm().Show();
		}

		private void AddCameraForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			newCamera = new CameraDefinition(txtHostAndPort.Text, txtUser.Text, txtPass.Text, cbHttps.Checked, txtDayZoom.Text, txtDayFocus.Text, txtNightZoom.Text, txtNightFocus.Text, (int)nudLensCmdDelay.Value, GetSelectedProfile(cbSunriseProfile, Profile.Day), GetSelectedProfile(cbSunsetProfile, Profile.Night), txtChannelNumbers.Text);
		}

		private void lblLensCmd_Click(object sender, EventArgs e)
		{
			MessageBox.Show("It has been my experience that the manual zoom/focus command is unreliable." +
				" For this reason, the program sends the command to the camera 4-5 times depending on the parameters being used." +
				" You can configure how long the program waits between sending the commands. (default: 4 seconds)");
		}

		private void lblLensCmdQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			lblLensCmd_Click(sender, e);
		}

		private void lblMultiSensorHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			lblMultiSensorQ_Click(sender, e);
		}

		private void lblMultiSensorQ_Click(object sender, EventArgs e)
		{
			MessageBox.Show("If your camera has multiple individually-configurable video channels you wish to control at sunrise/sunset, enter those channel numbers in the box, separated by commas. Each channel will be switched to the desired profile in sequence, 5 seconds apart." + Environment.NewLine + Environment.NewLine + "Note: Zoom/Focus is not channel-specific.");
		}

		private void txtChannelNumbers_TextChanged(object sender, EventArgs e)
		{
			if (CameraDefinition.GetChannelIndexes(txtChannelNumbers.Text, out int[] channelIndexes))
			{
				txtChannelNumbers.ForeColor = defaultChannelNumbersColor;
				txtChannelNumbers.BackColor = defaultChannelNumbersBgColor;
			}
			else
			{
				txtChannelNumbers.ForeColor = Color.FromArgb(200,0,0);
				txtChannelNumbers.BackColor = Color.FromArgb(255, 220, 220);
			}
		}
	}
}
