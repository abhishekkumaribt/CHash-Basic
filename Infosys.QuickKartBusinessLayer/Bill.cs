using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Bill
    {
        public Bill()
        {

        }
        public static double GenrateBill(PatientType patientType)
        {
            double billAmt = 0.0;
            if(patientType is Inpatient)
            {
                billAmt = patientType.CalculateConsultationFee() + ((Inpatient)patientType).roomCaharge();
            }
            if(patientType is Outpatient)
            {
                billAmt = patientType.CalculateConsultationFee();
            }
            return billAmt;
        }
    }
}
