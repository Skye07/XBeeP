using System;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Collections;
using System.Windows.Forms;
using XBeeP.packets;
//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   PCCom.SerialCommunication Version 1.0.0.0
//   Class file for managing serial port communication
//
//   Copyright (C) 2007  
//   Richard L. McCutchen 
//   Email: richard@psychocoder.net
//   Created: 20OCT07
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
//*****************************************************************************************
namespace XBeeP
{
    public class DataEventArgs : EventArgs
    {
        public packetBase Frame { get; set; }
        public DataEventArgs(packetBase frame)
            : base()
        {
            Frame = frame;
        }
    }

    class CommunicationManager
    {

        public delegate void newCompleteFrameEventHandler(object sender, DataEventArgs e);
        public event newCompleteFrameEventHandler newCompleteFrame = delegate { };

        #region Manager Enums
        /// <summary>
        /// enumeration to hold our transmission types
        /// </summary>
        public enum TransmissionType { Text, Hex }

        /// <summary>
        /// enumeration to hold our message types
        /// </summary>
        public enum MessageType { Incoming, Outgoing, Normal, Warning, Error };

        #endregion

        #region Manager Variables
        //property variables

        private int frameNr = 0;
        private string _baudRate = string.Empty;
        private string _parity = string.Empty;
        private string _stopBits = string.Empty;
        private string _dataBits = string.Empty;
        private string _portName = string.Empty;
        private TransmissionType _transType;
        private RichTextBox _displayWindow;
        //global manager variables
        private Color[] MessageColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        private SerialPort comPort = new SerialPort();

        private ArrayList frames = new ArrayList();

        #endregion

        #region Manager Properties

        public ArrayList Frames
        {
            get { return frames; }
        }

        
        /// <summary>
        /// Property to hold the BaudRate
        /// of our manager class
        /// </summary>
        public string BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        /// <summary>
        /// property to hold the Parity
        /// of our manager class
        /// </summary>
        public string Parity
        {
            get { return _parity; }
            set { _parity = value; }
        }

        /// <summary>
        /// property to hold the StopBits
        /// of our manager class
        /// </summary>
        public string StopBits
        {
            get { return _stopBits; }
            set { _stopBits = value; }
        }

        /// <summary>
        /// property to hold the DataBits
        /// of our manager class
        /// </summary>
        public string DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; }
        }

        /// <summary>
        /// property to hold the PortName
        /// of our manager class
        /// </summary>
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        /// <summary>
        /// property to hold our TransmissionType
        /// of our manager class
        /// </summary>
        public TransmissionType CurrentTransmissionType
        {
            get { return _transType; }
            set { _transType = value; }
        }

        /// <summary>
        /// property to hold our display window
        /// value
        /// </summary>
        public RichTextBox DisplayWindow
        {
            get { return _displayWindow; }
            set { _displayWindow = value; }
        }
        #endregion

        #region Manager Constructors
        /// <summary>
        /// Constructor to set the properties of our Manager Class
        /// </summary>
        /// <param name="baud">Desired BaudRate</param>
        /// <param name="par">Desired Parity</param>
        /// <param name="sBits">Desired StopBits</param>
        /// <param name="dBits">Desired DataBits</param>
        /// <param name="name">Desired PortName</param>
        public CommunicationManager(string baud, string par, string sBits, string dBits, string name, RichTextBox rtb)
        {
            _baudRate = baud;
            _parity = par;
            _stopBits = sBits;
            _dataBits = dBits;
            _portName = name;
            _displayWindow = rtb;
            //now add an event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
        }

        /// <summary>
        /// Comstructor to set the properties of our
        /// serial port communicator to nothing
        /// </summary>
        public CommunicationManager()
        {
            _baudRate = string.Empty;
            _parity = string.Empty;
            _stopBits = string.Empty;
            _dataBits = string.Empty;
            _portName = "COM1";
            _displayWindow = null;
            //add event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
        }
        #endregion

        #region WriteData
        public void WriteData(string msg)
        {
            switch (CurrentTransmissionType)
            {
                case TransmissionType.Text:
                    //first make sure the port is open
                    //if its not open then open it
                    if (!(comPort.IsOpen == true)) comPort.Open();
                    //send the message to the port
                    comPort.Write(msg);
                    //display the message
                    DisplayData(MessageType.Outgoing, msg + "\n");
                    break;
                case TransmissionType.Hex:
                    try
                    {
                        //convert the message to byte array
                        byte[] newMsg = HexToByte(msg);
                        //send the message to the port
                        comPort.Write(newMsg, 0, newMsg.Length);
                        //convert back to hex and display
                        DisplayData(MessageType.Outgoing, ByteToHex(newMsg) + "\n");
                    }
                    catch (FormatException ex)
                    {
                        //display error message
                        DisplayData(MessageType.Error, ex.Message);
                    }
                    finally
                    {
                        _displayWindow.SelectAll();
                    }
                    break;
                default:
                    //first make sure the port is open
                    //if its not open then open it
                    if (!(comPort.IsOpen == true)) comPort.Open();
                    //send the message to the port
                    comPort.Write(msg);
                    //display the message
                    DisplayData(MessageType.Outgoing, msg + "\n");
                    break;
            }
        }
        #endregion

        #region HexToByte
        /// <summary>
        /// method to convert hex string into a byte array
        /// </summary>
        /// <param name="msg">string to convert</param>
        /// <returns>a byte array</returns>
        private byte[] HexToByte(string msg)
        {
            //remove any spaces from the string
            msg = msg.Replace(" ", "");
            //create a byte array the length of the
            //divided by 2 (Hex is 2 characters in length)
            byte[] comBuffer = new byte[msg.Length / 2];
            //loop through the length of the provided string
            for (int i = 0; i < msg.Length; i += 2)
                //convert each set of 2 characters to a byte
                //and add to the array
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            //return the array
            return comBuffer;
        }
        #endregion

        #region ByteToHex
        /// <summary>
        /// method to convert a byte array into a hex string
        /// </summary>
        /// <param name="comByte">byte array to convert</param>
        /// <returns>a hex string</returns>
        private string ByteToHex(byte[] comByte)
        {
            //create a new StringBuilder object
            StringBuilder builder = new StringBuilder(comByte.Length * 3);
            //loop through each byte in the array
            foreach (byte data in comByte)
                //convert the byte to a string and add to the stringbuilder
                builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            //return the converted value
            return builder.ToString().ToUpper();
        }
        #endregion

        #region DisplayData
        /// <summary>
        /// method to display the data to & from the port
        /// on the screen
        /// </summary>
        /// <param name="type">MessageType of the message</param>
        /// <param name="msg">Message to display</param>
        [STAThread]
        private void DisplayData(MessageType type, string msg)
        {
            _displayWindow.Invoke(new EventHandler(delegate
        {
            _displayWindow.SelectedText = string.Empty;
            _displayWindow.SelectionFont = new Font(_displayWindow.SelectionFont, FontStyle.Bold);
            _displayWindow.SelectionColor = MessageColor[(int)type];
            _displayWindow.AppendText(msg);
            _displayWindow.ScrollToCaret();
        }));
        }
        #endregion

        #region OpenPort
        public bool OpenPort()
        {
            try
            {
                //first check if the port is already open
                //if its open then close it
                if (comPort.IsOpen == true) comPort.Close();

                //set the properties of our SerialPort Object
                comPort.BaudRate = int.Parse(_baudRate);    //BaudRate
                comPort.DataBits = int.Parse(_dataBits);    //DataBits
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _stopBits);    //StopBits
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), _parity);    //Parity
                comPort.PortName = _portName;   //PortName
                //now open the port
                comPort.Open();
                //display message
                if (_displayWindow.Text != "")
                    DisplayData(MessageType.Normal, "\n");
                DisplayData(MessageType.Normal, comPort.PortName + " opened at " + DateTime.Now + "\n");
                //return true
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
                return false;
            }
        }
        #endregion

        public bool ClosePort()
        {
            try
            {
                comPort.DiscardInBuffer();
                comPort.Close();
                DisplayData(MessageType.Normal, "\n"+comPort.PortName+" closed at " + DateTime.Now + "\n");
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
                return false;
            }
        }

        #region SetParityValues
        public void SetParityValues(object obj)
        {
            foreach (string str in Enum.GetNames(typeof(Parity)))
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region SetStopBitValues
        public void SetStopBitValues(object obj)
        {
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region SetPortNameValues
        public void SetPortNameValues(object obj)
        {

            foreach (string str in SerialPort.GetPortNames())
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region comPort_DataReceived
        /// <summary>
        /// method that will be called when theres data waiting in the buffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] incByte = new byte[3];
            int checksum = 0;

            if (comPort.BytesToRead > 0)
            {
                comPort.Read(incByte, 0, 1);

                if(incByte[0] == 0x7E)
                {
                    frameNr++;
                    comPort.Read(incByte, 0, 3);
                    int length = (incByte[1] + (incByte[0] << 8)) ; // Payload length + checksum byte

                    while (comPort.BytesToRead < length)
                        System.Threading.Thread.Sleep(50); // Wait until enough bytes have arrived

                    byte[] fbytes = new byte[length];
                    comPort.Read(fbytes, 0, length);

                    switch (incByte[2]) // Test the API identifier
                    {
                        case (byte)FrameType.ATCommand:
                            break;
                        case (byte)FrameType.ATCommandQPV:
                            break;
                        case (byte)FrameType.ATCommandResponse:
                            break;

                        case (byte)FrameType.InputLine16:
                            InputLine16 inframe = new InputLine16(this.frameNr, FrameType.InputLine16, length);
                            inframe.addHex(0x7E);
                            foreach(byte b in incByte)
                                inframe.addHex(b);
                            foreach(byte b in fbytes)
                                inframe.addHex(b);
                            inframe.SourceAddress = (fbytes[1] + (fbytes[0] << 8));
                            inframe.Rssi = fbytes[2];
                            inframe.Broadcast = fbytes[3];
                            inframe.SampleAmount = fbytes[4];
                            inframe.AdcStatus = (byte)(fbytes[5] >> 1); //Bitshift to remove the D8
                            inframe.DioStatus = fbytes[6];

                            int bcount = 8;
                            if (inframe.DioStatus > 0)
                            {
                                inframe.DioVal = fbytes[bcount++]; // MSB is zero as D8 is unused in current FW
                            }

                            if (inframe.AdcStatus > 0)
                            {
                                for (int i = 0; i <= 5; i++)
                                {
                                    if((inframe.AdcStatus & (1 << i)) != 0)
                                    {
                                        inframe.setAdcVal(i, fbytes[bcount+1] + (fbytes[bcount] << 8));
                                        bcount += 2;
                                    }
                                }
                            }
                            inframe.Checksum = fbytes[bcount];

                            checksum += incByte[2];
                            for (int i = 0; i < fbytes.Length-1; i++)
                                checksum += fbytes[i];
                            int res = 0xFF - (checksum & 0xFF);

                            if (res == inframe.Checksum)
                            {
                                Frames.Add(inframe);
                                newCompleteFrame(this, new DataEventArgs(inframe));
                            }
                            else
                                Console.Write("CHECKSUM FAILED! Got " + inframe.Checksum + " while expecting " + res);
                            break;

                        case (byte)FrameType.InputLine64:
                            break;
                        case (byte)FrameType.ModemStatus:
                            break;
                        case (byte)FrameType.RemoteATCmdReq:
                            break;
                        case (byte)FrameType.RemoteCmdResp:
                            break;
                        case (byte)FrameType.RXPacket16:
                            break;
                        case (byte)FrameType.RXPacket64:
                            break;
                        case (byte)FrameType.TXReq16:
                            break;
                        case (byte)FrameType.TXReq64:
                            break;
                        case (byte)FrameType.TXStatus:
                            break;

                        case (byte)FrameType.Unknown:
                        default:
                            throw new Exception("Unsupported Frame Type: " + incByte[2]);
                    }
                }
            }
            
            /*
            //determine the mode the user selected (binary/string)
            switch (CurrentTransmissionType)
            {
                //user chose string
                case TransmissionType.Text:
                    //read data waiting in the buffer
                    string msg = comPort.ReadExisting();
                    //display the data to the user
                    DisplayData(MessageType.Incoming, msg + "\n");
                    break;
                //user chose hex
                case TransmissionType.Hex:
                    //retrieve number of bytes in the buffer
                    int bytes = comPort.BytesToRead;
                    //create a byte array to hold the awaiting data
                    byte[] comBuffer = new byte[1];
                    //read the data and store it
                    comPort.Read(comBuffer, 0, 1);
                    //display the data to the user
                    if (comBuffer[0] == 0x7E)
                    {
                        DisplayData(MessageType.Normal, "\n");
                    }
                    DisplayData(MessageType.Incoming, ByteToHex(comBuffer));
                    break;
                default:
                    //read data waiting in the buffer
                    string str = comPort.ReadExisting();
                    //display the data to the user
                    DisplayData(MessageType.Incoming, str + "\n");
                    break;
            }*/
        }
        #endregion
    }
}
