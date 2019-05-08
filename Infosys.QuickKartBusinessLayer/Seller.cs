using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Seller
    {
        private string sellerId;
        private string sellerName;
        public string SellerId { get { return sellerId; } set { sellerId = value; } }
        public string SellerName { get { return sellerName; } set { Validator validate = new Validator(); if(validate.IsName(value)&&validate.HasLength(value,5,20)) sellerName = value; } }
        public string[] SellerLocation { get; set; }
        public Seller(string sellerId,string sellerName)
        {
            this.sellerId = sellerId;
            this.sellerName = sellerName;
        }
    }
}
