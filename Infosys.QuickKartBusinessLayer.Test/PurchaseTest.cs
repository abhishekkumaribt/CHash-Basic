using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infosys.QuickKartBusinessLayer.Test
{
    [TestClass]
    class PurchaseTest
    {
        [TestMethod]
        public void CalculateBillAmoountTest1()
        {
            DateTime dt = new DateTime(2019, 01, 15);
            Purchase purchase = new Purchase(3, "Address", dt, "Cash");
            Assert.AreEqual(purchase.CalculateBillAmount(2690.0, 3), 7827.9);
        }
        [TestMethod]
        public void CalculateBillAmoountTest2()
        {
            DateTime dt = new DateTime(2019, 01, 15);
            Purchase purchase = new Purchase(3, "Address", dt, "Cash");
            Assert.AreEqual(purchase.CalculateBillAmount(-2690.0, 3), -7827.9);
        }
        [TestMethod]
        public void CalculateBillAmoountTest3()
        {
            DateTime dt = new DateTime(2019, 01, 15);
            Purchase purchase = new Purchase(3, "Address", dt, "Cash");
            Assert.AreEqual(purchase.CalculateBillAmount(0, 0), 0);
        }
    }
}
