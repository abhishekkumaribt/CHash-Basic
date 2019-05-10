using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class LifeInsurancePolicy:InsurancePolicy
    {
        public int Age { get; set; }
        public string MedicalHistory { get; set; }
        public LifeInsurancePolicy()
        {

        }
        public LifeInsurancePolicy(int age,string medicalHistory,double policyCover,int policyTerm):base(policyTerm)
        {
            Age = age;
            MedicalHistory = medicalHistory;
            PolicyCover = policyCover;
        }
        public override double CalculatePolicyCover()
        {
            return PolicyCover;
        }
        public override double CalculateRisk()
        {
            if (Age <= 25)
                Risk += 0.05;
            else if (Age <= 40)
                Risk += 0.1;
            else if (Age <= 55)
                Risk += 0.15;
            else
                Risk += 0.2;
            switch (MedicalHistory)
            {
                case "Clear":
                    Risk += 0.05;
                    break;
                case "Minor":
                    Risk += 0.1;
                    break;
                case "Moderate":
                    Risk += 0.15;
                    break;
                case "Major":
                    Risk += 0.2;
                    break;
            }
            return Risk;
        }
    }
}
