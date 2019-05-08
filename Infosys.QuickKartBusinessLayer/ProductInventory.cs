using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class ProductInventory
    {
        private int inventoryId;
        private int quantityInHand;
        public int InventoryId { get { return inventoryId; } set { inventoryId = value; } }
        public int QuantityInHand { get { return quantityInHand; } set { if (value > 0) quantityInHand = value; } }
        public ProductInventory(int inventoryId,int quantityInHand)
        {
            InventoryId = inventoryId;
            QuantityInHand = quantityInHand;
        }
    }
}
