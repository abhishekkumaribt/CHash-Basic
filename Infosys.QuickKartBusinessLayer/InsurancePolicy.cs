using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public abstract class InsurancePolicy
    {
        public double PolicyCover { get; set; }
        public int PolicyTerm { get; set; }
        public double Premium { get; set; }
        public double Risk { get; set; }
        public InsurancePolicy()
        {
            
        }
        public InsurancePolicy(int policyTerm)
        {
            PolicyTerm = policyTerm;
        }
        public abstract double CalculatePolicyCover();
        public double CalculatePremium()
        {
            PolicyCover = CalculatePolicyCover();
            Risk = CalculateRisk();
            Premium = PolicyCover * Risk / PolicyTerm;
            return Premium;
        }
        public abstract double CalculateRisk();
    }
}
