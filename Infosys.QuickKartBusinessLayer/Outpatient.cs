using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Outpatient:PatientType
    {
        public Outpatient()
        {

        }
        public Outpatient(string name, int age, char gender, string illness):base(name,age,gender,illness)
        {

        }
        public override double CalculateConsultationFee()
        {
            if (Illness == "Cough" || Illness == "Fever")
                return base.CalculateConsultationFee() - 10;
            else
                return base.CalculateConsultationFee() + 10;
        }
    }
}
