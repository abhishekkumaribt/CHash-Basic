using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Seller
    {
        private string sellerId;
        private string sellerName;
        public static int sellerIdCount;
        public string SellerId { get { return sellerId; } }
        public string SellerName { get { return sellerName; } set { Validator validate = new Validator(); if(validate.IsName(value)&&validate.HasLength(value,5,20)) sellerName = value; } }
        public string[] SellerLocation { get; set; }
        static Seller()
        {
            sellerIdCount = 1001;
        }
        private Seller()
        {
            sellerId = "S" + sellerIdCount.ToString();
            sellerIdCount += 1;
        }
        public Seller(string sellerName):this()
        {
            SellerName = sellerName;
        }
    }
}
