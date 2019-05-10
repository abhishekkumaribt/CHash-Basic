using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer.Hand_on_Try_out_2
{
    public class PostPaidServices:ServiceCenter
    {
        public static int counter;
        public double CallRatePerMin { get; set; }
        public double CarryForward { get; set; }
        public double DataRate { get; set; }
        public string PostPaidPlan { get; set; }
        public double SmsRate { get; set; }
        public Usage Usage { get; set; }
        static PostPaidServices()
        {
            counter = 1;
        }
        public PostPaidServices(Usage usage,string postPaidPlan,double carryForward,long phoneNumber,string location):base(phoneNumber,location)
        {
            PostPaidPlan = postPaidPlan;
            CarryForward = carryForward;
        }
        public double CalculatePostPaidBill()
        {
            double bill;
            GetPhoneRates();
            if (PostPaidPlan == "UP")
                bill = 999 - CarryForward;
            else
                bill = (Usage.CallDurationInMins * CallRatePerMin) + (Usage.NumberOfSmsSent * SmsRate) + (Usage.DataUsageInGB * DataRate) - CarryForward;
            return bill;
        }
        public void GetPhoneRates()
        {
            switch (PostPaidPlan)
            {
                case "BP":
                    CallRatePerMin = 1;
                    SmsRate = 0.5;
                    DataRate = 250;
                    break;
                case "FSP":
                    CallRatePerMin = 1.5;
                    SmsRate = 0;
                    DataRate = 200;
                    break;
                case "CP":
                    CallRatePerMin = 0.95;
                    SmsRate = 0.55;
                    DataRate = 300;
                    break;
                default:
                    CallRatePerMin = 0;
                    SmsRate = 0;
                    DataRate = 0;
                    break;
            }
        }
        public override int MakePayment(double amountPaid, out string billId, bool notifyBySms)
        {
            double bill = CalculatePostPaidBill();
            if(amountPaid>=bill)
            {
                CarryForward = bill - amountPaid;
                billId = "T" + counter;
                counter++;
                return 1;
            }
            else
            {
                billId = "NA";
                return -1;
            }
        }
        public override bool ValidatePlanDetails(List<string> availablePostPaidPlan)
        {
            return availablePostPaidPlan.Contains(PostPaidPlan);
        }
    }
}
