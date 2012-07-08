using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XBeeP.packets;

namespace XBeeP.usercontrols
{
    public partial class InputLine16Control : UserControl
    {
        public InputLine16Control()
        {
            InitializeComponent();
        }

        public void FillForm(InputLine16 p, float step)
        {
            rssiInfoLbl.Text = "" + p.Rssi + " -dBm";
            switch (p.Broadcast)
            {
                case 0:
                    broadcastInfoLbl.Text = "OFF";
                    break;
                case 2:
                    broadcastInfoLbl.Text = "Address";
                    break;
                case 4:
                    broadcastInfoLbl.Text = "PAN";

                    break;
                default:
                    break;
            }
            
            sourceInfoLbl.Text = "" + p.SourceAddress.ToString("X");
            samplesInfoLbl.Text = "" + p.SampleAmount;
            anaMaskInfoLbl.Text = "" + Convert.ToString(p.AdcStatus, 2).PadLeft(8, '0');

            ad0InfoLbl.Text = Math.Round(p.getAdcVal(0) * step, 3) >= 0 ? "" + Math.Round(p.getAdcVal(0) * step, 3) : "OFF";
            ad1InfoLbl.Text = Math.Round(p.getAdcVal(1) * step, 3) >= 0 ? "" + Math.Round(p.getAdcVal(1) * step, 3) : "OFF";
            ad2InfoLbl.Text = Math.Round(p.getAdcVal(2) * step, 3) >= 0 ? "" + Math.Round(p.getAdcVal(2) * step, 3) : "OFF";
            ad3InfoLbl.Text = Math.Round(p.getAdcVal(3) * step, 3) >= 0 ? "" + Math.Round(p.getAdcVal(3) * step, 3) : "OFF";
            ad4InfoLbl.Text = Math.Round(p.getAdcVal(4) * step, 3) >= 0 ? "" + Math.Round(p.getAdcVal(4) * step, 3) : "OFF";
            ad5InfoLbl.Text = Math.Round(p.getAdcVal(5) * step, 3) >= 0 ? "" + Math.Round(p.getAdcVal(5) * step, 3) : "OFF";
            
            digiMaskInfoLbl.Text = "" + Convert.ToString(p.DioStatus, 2).PadLeft(8, '0');

            d0InfoLbl.Text = "" + p.SingleDioVal(0);
            d1InfoLbl.Text = "" + p.SingleDioVal(1);
            d2InfoLbl.Text = "" + p.SingleDioVal(2);
            d3InfoLbl.Text = "" + p.SingleDioVal(3);
            d4InfoLbl.Text = "" + p.SingleDioVal(4);
            d5InfoLbl.Text = "" + p.SingleDioVal(5);
            d6InfoLbl.Text = "" + p.SingleDioVal(6);
            d7InfoLbl.Text = "" + p.SingleDioVal(7);
        }
    }
}
