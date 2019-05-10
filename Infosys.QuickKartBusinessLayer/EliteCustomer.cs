using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class EliteCustomer:Customer
    {
        private int ownedCoupons;
        public int OwnedCoupons { get { return ownedCoupons; } set { if(value>0) ownedCoupons = value; } }
        public EliteCustomer(string customerName,string address,DateTime dateOfBirth,string emailId,Gender gender,string password,int ownedCoupons) : base(customerName, address, dateOfBirth, emailId, gender, password)
        {
            OwnedCoupons = ownedCoupons;
        }
        public override double CalculateDiscount()
        {
            double discount;
            discount = OwnedCoupons * 10;
            OwnedCoupons = 10;
            return discount;
        }
    }
}
