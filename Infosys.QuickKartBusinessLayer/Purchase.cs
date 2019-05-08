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
        public static int purchaseCounter;
        public DateTime DateOfPurchase { get { return dateOfPurchase; } set { dateOfPurchase = value; } }
        public string PaymentType { get { return paymentType; } set { paymentType = value; } }
        public string PurchaseId { get { return purchaseId; } }
        public int QuantityOrdered { get { return quantityOrdered; } set { quantityOrdered = value; } }
        public string ShippingAddress { get { return shippingAddress; } set { Validator validate = new Validator();if (validate.IsName(value)) shippingAddress = value; } }
        static Purchase()
        {
            purchaseCounter = 1001;
        }
        private Purchase()
        {
            purchaseId = "B" + purchaseCounter.ToString();
            purchaseCounter += 1;
        }
        public Purchase(int quantityOrdered,string shippingAddress,DateTime dateOfPurchase,string paymentType):this()
        {
            DateOfPurchase = dateOfPurchase;
            PaymentType = paymentType;
            QuantityOrdered = quantityOrdered;
            ShippingAddress = shippingAddress;
        }
        public double CalculateBillAmount(double price)
        {
            double amount;
            amount = QuantityOrdered * price;
            return amount;
        }
        public double CalculateBillAmount(double price,double discountPercentage)
        {
            double discountPrice;
            double totalPrice = CalculateBillAmount(price);
            discountPrice = totalPrice - (totalPrice * discountPercentage / 100);
            return discountPrice;
        }
        static double RoundOffBill(double amount)
        {
            return Math.Round(amount, 2);
        }
        static int GetPurchasePercentage(DateTime[] transactionDates, DateTime dateForReport)
        {
            int percnt=0;
            int purchaseOnSameDate = 0;
            int totalPurchase = transactionDates.Length;
            foreach (DateTime day in transactionDates)
                if (day.Date == dateForReport.Date)
                    purchaseOnSameDate++;
            if (totalPurchase > 0)
                percnt = (purchaseOnSameDate / totalPurchase) * 100;
            return percnt;
        }
    }
}
