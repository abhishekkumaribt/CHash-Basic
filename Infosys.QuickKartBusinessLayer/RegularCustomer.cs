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
        public override double CalculateDiscount()
        {
            double discount = 0;
            DateTime zero = new DateTime(1, 1, 1);
            if((zero+(DateTime.Today-DateOfBirth.Date)).Year>22 && Gender==Gender.Female)
            {
                discount = base.CalculateDiscount() + 2;
            }
            else if ((zero + (DateTime.Today - DateOfBirth.Date)).Year > 25 && Gender == Gender.Male)
            {
                discount = base.CalculateDiscount() + 1.5;
            }
            else
            {
                discount = base.CalculateDiscount();
            }
            return discount;
        }
    }
}
