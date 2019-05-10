using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class VehicleInsurancePolicy:InsurancePolicy
    {
        public string VehicleCondition { get; set; }
        public double VehiclePrice { get; set; }
        public string VehicleType { get; set; }
        public VehicleInsurancePolicy()
        {

        }
        public VehicleInsurancePolicy(string vehicleType,double vehiclePrice,string vehicleCondition,int policyTerm):base(policyTerm)
        {
            VehicleType = vehicleType;
            VehiclePrice = vehiclePrice;
            VehicleCondition = vehicleCondition;
        }
        public override double CalculatePolicyCover()
        {
            switch (VehicleCondition)
            {
                case "New":
                    PolicyCover = 0.9 * VehiclePrice;
                    break;
                case "Good":
                    PolicyCover = 0.75 * VehiclePrice;
                    break;
                case "Old":
                    PolicyCover = 0.5 * VehiclePrice;
                    break;
            }
            return PolicyCover;
        }
        public override double CalculateRisk()
        {
            switch (VehicleType)
            {
                case "Sports":
                    Risk = 0.35;
                    break;
                case "Logistics":
                    Risk = 0.4;
                    break;
                case "Sedan":
                    Risk = 0.2;
                    break;
                default:
                    Risk = 0.15;
                    break;
            }
            return Risk;
        }
    }
}
