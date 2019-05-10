using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class PatientType
    {
        public int Age { get; set; }
        public double ConsultationFee { get; set; }
        public char Gender { get; set; }
        public string Illness { get; set; }
        public string Name { get; set; }
        public PatientType()
        {

        }
        public PatientType(string name,int age,char gender,string illness)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Illness = illness;
        }
        public virtual double CalculateConsultationFee()
        {
            double consultationFee = 0;
            if (Age > 0 && Age <= 18)
                consultationFee = Age * 10;
            else if (Age > 18)
            {
                consultationFee = Age * 15;
            }
            return consultationFee;
        }
    }
}
