using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer.Hand_on_Try_out_2
{
    public abstract class ServiceCenter
    {
        public string LocationId { get; set; }
        public long PhoneNumber { get; set; }
        public ServiceCenter(long phoneNumber,string locationId)
        {
            PhoneNumber = phoneNumber;
            LocationId = locationId;
        }
        public abstract int MakePayment(double amountPaid, out string billId, bool notifyBySms);
        public abstract bool ValidatePlanDetails(List<string> availablePostPaidPlan);
    }
}
