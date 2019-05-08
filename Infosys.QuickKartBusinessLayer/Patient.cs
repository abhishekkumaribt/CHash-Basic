using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class Patient
    {
        private string[] labTestId;
        private int patientId;
        private string patientName;
        public Patient(int patientId, string patientName, string[] labTestId)
        {
            this.patientId = patientId;
            this.patientName = patientName;
            this.labTestId = labTestId;
        }
        public double CalculateCharge()
        {
            double totalCharge = 0;
            foreach (string testId in labTestId)
                totalCharge += LabTestRepository.GetCharge(testId);
            return totalCharge;
        }
    }
}
