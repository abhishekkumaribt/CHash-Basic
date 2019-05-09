using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class RegularCustomer:Customer
    {
        private double discountPercentage;
        public double DiscountPercentage { get { return discountPercentage; } set { if(value>0) discountPercentage = value; } }
        public RegularCustomer(string customerName, string address, DateTime dateOfBirth, string emailId, Gender gender, string password):base(customerName, address, dateOfBirth, emailId, gender, password)
        {
            DiscountPercentage = 2;
        }
    }
}
