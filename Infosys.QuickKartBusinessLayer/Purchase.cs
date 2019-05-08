using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Purchase
    {
        private DateTime dateOfPurchase;
        private string paymentType;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;
        public Purchase(string purchaseId,int quantityOrdered,string shippingAddress,DateTime dateOfPurchase,string paymentType)
        {
            this.dateOfPurchase = dateOfPurchase;
            this.paymentType = paymentType;
            this.purchaseId = purchaseId;
            this.quantityOrdered = quantityOrdered;
            this.shippingAddress = shippingAddress;
        }
        public double CalculateBillAmount(double price)
        {
            double amount;
            amount = quantityOrdered * price;
            return amount;
        }
        public double CalculateBillAmount(double price,double discountPercentage)
        {
            double discountPrice;
            double totalPrice = CalculateBillAmount(price);
            discountPrice = totalPrice - (totalPrice * discountPercentage / 100);
            return discountPrice;
        }
    }
}
