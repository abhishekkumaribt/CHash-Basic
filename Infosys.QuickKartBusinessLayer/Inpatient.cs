using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Inpatient:PatientType
    {
        private int days;
        public int Days { get { return days; } set { if (value > 0) days = value; else days = 1; } }
        public double ExtraService { get; set; }
        public double PerDayService { get; set; }
        public Inpatient()
        {

        }
        public Inpatient(string name, int age, char gender, string illness,int days):base(name,age,gender,illness)
        {
            Days = days;
            PerDayService = 155.50;
            ExtraService = 100;
        }
        public override double CalculateConsultationFee()
        {
            return base.CalculateConsultationFee() + ExtraService;
        }
        public double roomCaharge()
        {
            double serviceCharge;
            if (Days <= 7)
                serviceCharge = Days * PerDayService;
            else
                serviceCharge = (Days * PerDayService) + (Days * ExtraService);
            return serviceCharge;
        }
    }
}
