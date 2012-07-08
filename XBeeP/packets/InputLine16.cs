using System;
using System.Collections.Generic;
using System.Text;

namespace XBeeP.packets
{
    public class InputLine16 : packetBase
    {

#region properties

        private byte addressMode;

        public byte AddressMode
        {
            get { return addressMode; }
             set { addressMode = value; }
        }
        private int sourceAddress;

        public int SourceAddress
        {
            get { return sourceAddress; }
             set { sourceAddress = value; }
        }
        private byte rssi;

        public byte Rssi
        {
            get { return rssi; }
             set { rssi = value; }
        }

        private byte broadcast;

        public byte Broadcast
        {
            get { return broadcast; }
            set { broadcast = value; }
        }

        private byte sampleAmount;

        public byte SampleAmount
        {
            get { return sampleAmount; }
             set { sampleAmount = value; }
        }
        private byte adcStatus;

        public byte AdcStatus
        {
            get { return adcStatus; }
             set { adcStatus = value; }
        }
        private int[] adcVal = new int[6];

        public int getAdcVal(int channel)
        {
            if ((AdcStatus & (1 << channel)) != 0)
            {
                return adcVal[channel];
            }
            else
                return -1;



        }
        public void setAdcVal(int channel, int value)
        {
            adcVal[channel] = value;
        }


        private byte dioStatus;

        public byte DioStatus
        {
            get { return dioStatus; }
             set { dioStatus = value; }
        }
        private byte dioVal;

        public byte DioVal
        {
            get { return dioVal; }
             set { dioVal = value; }
        }

        public String SingleDioVal(int channel)
        {
            if ((dioStatus & (1 << channel)) != 0)
            {
                if((dioVal & (1 << channel)) != 0)
                    return "1";
                else
                    return "0";
            }
            else
                return "OFF";
        }



#endregion

        public InputLine16(int frameNumber, FrameType type, int length)
            : base(frameNumber, type, length, 0, DateTime.Now)
        {
        }

        public override String ToString()
        {
            return this.Type + " - Source: " + this.SourceAddress.ToString("X");
        }

        public byte[] getFrameHex() //TODO
        {
            byte[] hex = new byte[] {(byte)0x7E, 0, (byte)Length,  (byte)FrameType.InputLine16, Rssi, 0, SampleAmount, AdcStatus, DioStatus, 0, DioVal};
            return hex;
        }

        public String getFrameASCII()
        {
            return "TODO";
        }


    }
}
