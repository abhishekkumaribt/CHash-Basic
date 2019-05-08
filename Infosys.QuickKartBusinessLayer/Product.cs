using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Infosys.QuickKartBusinessLayer
{
    public class Product
    {
        private Category category;
        private string description;
        private double price;
        private string productId;
        private string productName;
        private int quantityAvailable;
        public static int currentProductId;
        public Category Category { get { return category; } set { category = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { if (value>0) { price = value; } } }
        public string ProductId { get { return productId; } }
        public string ProductName { get { return productName; } set { Validator validate = new Validator();if (validate.IsName(value)){ productName = value; } } }
        public int QuantityAvailable { get { return quantityAvailable; } set { quantityAvailable = value; } }
        static Product()
        {
            currentProductId = 100;
        }
        private Product()
        {
            productId = "P" + currentProductId.ToString();
            currentProductId += 1;
        }
        public Product(string productName,string description,double price,Category category):this()
        {
            Description = description;
            Price = price;
            ProductName = productName;
            Category = category;
        }
        public Product(string productName, string description, int quantityAvailable):this()
        {
            Description = description;
            QuantityAvailable = quantityAvailable;
            ProductName = productName;
        }
        public Product(string productName, double price, int quantityAvailable):this()
        {
            Price = price;
            QuantityAvailable = quantityAvailable;
            ProductName = productName;
        }
        public bool CheckAvailability(int quantityPurchased)
        {
            return (quantityPurchased <= QuantityAvailable);
        }
    }
}
