using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer.Hand_on_Try_out_2
{
    public class Usage
    {
        public int CallDurationInMins { get; set; }
        public int DataUsageInGB { get; set; }
        public int NumberOfSmsSent { get; set; }
        public Usage(int dataUsageInGB, int callDurationInMins, int noOfSmsSent)
        {
            DataUsageInGB = dataUsageInGB;
            CallDurationInMins = callDurationInMins;
            NumberOfSmsSent = noOfSmsSent;
        }
    }
}
