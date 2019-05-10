using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class PrivilegedCustomer:Customer
    {
        private CustomerCardType cardType;
        public CustomerCardType CardType { get { return cardType; } set { cardType = value; } }
        public PrivilegedCustomer(string customerName,string address,DateTime dateOfBirth,string emailId,Gender gender,string password,CustomerCardType cardType) : base(customerName, address, dateOfBirth, emailId, gender, password)
        {
            CardType = cardType;
        }
        public override double CalculateDiscount()
        {
            double discount = 0;
            if (CardType == CustomerCardType.Silver)
            {
                discount = 3;
            }
            else if (cardType == CustomerCardType.Gold){
                discount = 5;
            }
            else if (cardType == CustomerCardType.Platinum)
            {
                discount = 7;
            }
            return discount;
        }
    }
}
