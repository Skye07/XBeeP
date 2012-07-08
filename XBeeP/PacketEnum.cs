using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XBeeP
{
    public enum FrameType
    {
        ModemStatus = 0x8A, ATCommand = 0x08, ATCommandQPV = 0x09, ATCommandResponse = 0x88,
        RemoteATCmdReq = 0x17, RemoteCmdResp = 0x97, TXReq64 = 0x00, TXReq16 = 0x01, TXStatus = 0x89,
        RXPacket64 = 0x80, RXPacket16 = 0x81, InputLine16 = 0x83, InputLine64 = 0x82, Unknown = 0xFF
    };
}
