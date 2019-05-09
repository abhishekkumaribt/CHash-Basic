using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class LabTestRepository
    {
        private static double[] labTestCharge;
        private static string[] labTestId;
        public LabTestRepository()
        {
            labTestId = new string[] { "L1", "L2", "L3", "L4" };
            labTestCharge = new double[] { 500, 200, 700, 900 };
        }
        public static double GetCharge(string testId)
        {
            return labTestCharge[Array.IndexOf(labTestId, testId)];
        }
    }
}
