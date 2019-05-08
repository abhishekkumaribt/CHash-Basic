using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Infosys.QuickKartBusinessLayer
{
    public class Product
    {
        private string description;
        private double price;
        private string productId;
        private string productName;
        private int quantityAvailable;

        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { if (value>0) { price = value; } } }
        public string ProductId { get { return productId; } set { productId = value; } }
        public string ProductName { get { return productName; } set { Validator validate = new Validator();if (validate.IsName(value)){ productName = value; } } }
        public int QuantityAvailable { get { return quantityAvailable; } set { quantityAvailable = value; } }
        public Product(string productId,string productName,string description,double price)
        {
            Description = description;
            Price = price;
            ProductId = productId;
            ProductName = productName;
        }
        public Product(string productId, string productName, string description, int quantityAvailable)
        {
            Description = description;
            QuantityAvailable = quantityAvailable;
            ProductId = productId;
            ProductName = productName;
        }
        public Product(string productId, string productName, double price, int quantityAvailable)
        {
            Price = price;
            QuantityAvailable = quantityAvailable;
            ProductId = productId;
            ProductName = productName;
        }
        public bool CheckAvailability(int quantityPurchased)
        {
            return (quantityPurchased <= QuantityAvailable);
        }
    }
}
