using System;
using System.Collections.Generic;
using System.Text;

namespace XBeeP.packets
{
    public abstract class packetBase
    {
        #region properties
        
        private int frameNumber;

        public int FrameNumber
        {
            get { return frameNumber; }
            private set { frameNumber = value; }
        }
        private int length;

        public int Length
        {
            get { return length; }
            private set { length = value; }
        }

        private byte checksum;
        
        public byte Checksum
        {
            get { return checksum; }
            set { checksum = value; }
        }

        private DateTime recTime;

        public DateTime RecTime
        {
            get { return recTime; }
            private set { recTime = value; }
        }


        private FrameType type;

        public FrameType Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

public packetBase()
        {
        }

        public packetBase(int frameNumber, FrameType type, int length, byte checksum, DateTime recTime)
        {
            this.frameNumber = frameNumber;
            this.length = length;
            this.checksum = checksum;
            this.recTime = recTime;
            this.type = type;
        }
        public override String ToString()
        {
            return "" + this.frameNumber;
        }


    }

}
