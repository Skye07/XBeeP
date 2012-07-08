using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XBeeP;
using System.Collections;
using XBeeP.packets;
using XBeeP.usercontrols;
namespace XBeeP
{
	public partial class frmMain : Form
	{
		CommunicationManager comm;
		string transType = string.Empty;
		float vref;
		int resolution;

		public frmMain()
		{
			InitializeComponent();
			comm = new CommunicationManager();
			comm.newCompleteFrame += delegate(object sender, DataEventArgs e) { UpdateFrameList(e.Frame); };
			resolution = (int)Math.Pow(2, (int)resolutionUpDown.Value);
			vref = (float)vrefUpDown.Value;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
		   LoadValues();
		   SetDefaults();
		   SetControlState();
		}

		private void cmdToggle_Click(object sender, EventArgs e)
		{
			if (cmdToggle.Text == "Open Port")
			{
				comm.Parity = cboParity.Text;
				comm.StopBits = cboStop.Text;
				comm.DataBits = cboData.Text;
				comm.BaudRate = cboBaud.Text;
				comm.DisplayWindow = rtbDisplay;
				comm.PortName = cboPort.Text;
				comm.OpenPort();
				cmdToggle.Text = "Close Port";
				cmdSend.Enabled = true;
				sendFrameBtn.Enabled = true;    
			}
			else
			{
				comm.ClosePort();
				cmdSend.Enabled = false;
				sendFrameBtn.Enabled = false;    
				cmdToggle.Text = "Open Port";
			}
		}

		/// <summary>
		/// Method to initialize serial port
		/// values to standard defaults
		/// </summary>
		private void SetDefaults()
		{
			cboPort.SelectedIndex = 0;
			cboBaud.SelectedText = "9600";
			cboParity.SelectedIndex = 0;
			cboStop.SelectedIndex = 1;
			cboData.SelectedIndex = 1;

			frameTypeCombo.Items.Add(FrameType.ATCommand);
			frameTypeCombo.Items.Add(FrameType.ATCommandQPV);
			frameTypeCombo.Items.Add(FrameType.RemoteATCmdReq);
		}

		/// <summary>
		/// methos to load our serial
		/// port option values
		/// </summary>
		private void LoadValues()
		{
			comm.SetPortNameValues(cboPort);
			comm.SetParityValues(cboParity);
			comm.SetStopBitValues(cboStop);
		}

		/// <summary>
		/// method to set the state of controls
		/// when the form first loads
		/// </summary>
		private void SetControlState()
		{
			rdoHex.Checked = true;
			cmdSend.Enabled = false;
		}

		public void UpdateFrameList(ArrayList frameArray)
		{
			foreach(packetBase fr in frameArray)
				lstFrames.Items.Add(fr);
		}

		public void UpdateFrameList(packetBase frame)
		{
		   

			lstFrames.Invoke(new Action(() => 
				{   lstFrames.Items.Add(frame);
					if(scrollChk.Checked)
						lstFrames.SelectedIndex = lstFrames.Items.Count - 1;
				}));

			
		}

		private void SwitchToPacket(packetBase p)
		{
			frameNrInfoLbl.Text = ""+p.FrameNumber;
			lengthInfoLbl.Text = "" + p.Length;
			checksumInfoLbl.Text = "" + p.Checksum;
			verifySumInfoLbl.Text = "...";
			typeInfoLbl.Text = "" + p.Type;
			recTimeInfoLbl.Text = ""+p.RecTime;
			hexTxtbox.Clear();
			asciiTxtbox.Clear();

			switch (p.Type)
			{
				case FrameType.ATCommand:
					break;
				case FrameType.ATCommandQPV:
					break;
				case FrameType.ATCommandResponse:
					break;
				case FrameType.InputLine16:
					InputLine16Control ctl = new InputLine16Control();
					InputLine16 ip = (InputLine16)p;
					ctl.Dock = DockStyle.Fill;
					ctl.FillForm(ip, vref/resolution);
					frPanel.Controls.Add(ctl);
					
                    ArrayList hex = ip.getHex();
					foreach (byte b in hex)
						hexTxtbox.Text += "" + b.ToString("X").PadLeft(2, '0') + " ";
                    foreach (byte b in hex)
                        asciiTxtbox.Text += "" + System.Convert.ToChar(System.Convert.ToUInt32(""+b, 16)).ToString() + " ";

					break;

				case FrameType.InputLine64:
					break;
				case FrameType.ModemStatus:
					break;
				case FrameType.RemoteATCmdReq:
					break;
				case FrameType.RemoteCmdResp:
					break;
				case FrameType.RXPacket16:
					break;
				case FrameType.RXPacket64:
					break;
				case FrameType.TXReq16:
					break;
				case FrameType.TXReq64:
					break;
				case FrameType.TXStatus:
					break;
				case FrameType.Unknown:
				default:
					break;
			}

			while(frPanel.Controls.Count > 1) 
			{
				Control c = frPanel.Controls[0];
				frPanel.Controls.Remove(c);
				c.Dispose(); 
				
			}
		}

		private void cmdSend_Click(object sender, EventArgs e)
		{
			comm.WriteData(txtSend.Text);
		}

		private void rdoHex_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoHex.Checked == true)
			{
				comm.CurrentTransmissionType = XBeeP.CommunicationManager.TransmissionType.Hex;
			}
			else
			{
				comm.CurrentTransmissionType = XBeeP.CommunicationManager.TransmissionType.Text;
			}
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			rtbDisplay.Clear();
		}

		private void lstFrames_SelectedIndexChanged(object sender, EventArgs e)
		{
			packetBase p = (packetBase)lstFrames.SelectedItem;
			SwitchToPacket(p);
		}

		private void vrefUpDown_ValueChanged(object sender, EventArgs e)
		{
			vref = (float)vrefUpDown.Value;
		}

		private void resolutionUpDown_ValueChanged(object sender, EventArgs e)
		{
			resolution = (int)Math.Pow(2, (int)resolutionUpDown.Value);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("XBeeP - Copyright 2012 Devon Kerkhove\nhttp://devon.skyon.be\ndevon@skyon.be", "XBeeP 0.2");
		}

		private void sendFrameBtn_Click(object sender, EventArgs e)
		{
			comm.WriteData(hexOutTxt.Text);
			sendStatusLbl.Text = "["+DateTime.Now+"] Frame sent with content: " + hexOutTxt.Text;
		}


	}
}