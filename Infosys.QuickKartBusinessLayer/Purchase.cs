using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Purchase:ITax
    {
        private Customer customer;
        private DateTime dateOfPurchase;
        private string paymentType;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;
        public static int purchaseCounter;
        public Customer Customer { get { return customer; } set { customer = value; } }
        public DateTime DateOfPurchase { get { return dateOfPurchase; } set { dateOfPurchase = value; } }
        public string PaymentType { get { return paymentType; } set { paymentType = value; } }
        public string PurchaseId { get { return purchaseId; } }
        public int QuantityOrdered { get { return quantityOrdered; } set { quantityOrdered = value; } }
        public string ShippingAddress { get { return shippingAddress; } set { Validator validate = new Validator();if (validate.IsName(value)) shippingAddress = value; } }
        static Purchase()
        {
            purchaseCounter = 1001;
        }
        public Purchase()
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
        public double CalculateBillAmount(params Product[] products)
        {
            double totalPrice = 0;
            foreach(Product p in products)
            {
                totalPrice += p.Price * QuantityOrdered;
            }
            double serviceTax = totalPrice * 0.07;
            double discountPercentage = CalculateDiscount();
            totalPrice = (totalPrice + serviceTax) * (1 - discountPercentage);
            return totalPrice;
        }
        public double CalculateBillAmount(Product product, int quantityRequired)
        {
            double totalPrice = product.Price * quantityRequired;
            double serviceTax = totalPrice * 0.07;
            double discountPercentage = CalculateDiscount();
            totalPrice = (totalPrice + serviceTax) * (1 - discountPercentage);
            return totalPrice;
        }
        public double CalculateDiscount()
        {
            return 0.05;
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

        public double PayTax(double price)
        {
            double tax = price * QuantityOrdered;
            switch (PaymentType)
            {
                case "Debit Card":
                    tax *= 1.02;
                    break;
                case "Credit Card":
                    tax *= 1.03;
                    break;
                case "Cash":
                    tax *= 1.01;
                    break;
                default:
                    tax *= 1.04;
                    break;
            }
            return tax;
        }
    }
}
