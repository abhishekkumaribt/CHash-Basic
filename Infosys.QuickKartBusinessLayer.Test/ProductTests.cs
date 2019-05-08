using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infosys.QuickKartBusinessLayer.Test
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductTest()
        {
            Product pObjOne = new Product("P101", "Motorola G3 Turbo", 18000, 3);
            Product pObjTwo = new Product("P102", "Nike Shoes", 2500, 3);
            Assert.AreNotSame(pObjOne, pObjTwo);
        }
        [TestMethod]
        public void CheckAvailabilityTest()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 18000, 3);
            int quantityPurchased = 10;

            bool actual = target.CheckAvailability(quantityPurchased);
            bool expected = false;

            Assert.AreEqual(expected, actual);

            // Test Case: 2
            target = new Product("P101", "Motorola G3 Turbo", 18000, 3);
            quantityPurchased = 2;

            actual = target.CheckAvailability(quantityPurchased);
            expected = true;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateBillAmoountTest1()
        {
            DateTime dt = new DateTime(2019, 01, 15);
            Purchase purchase = new Purchase("1001", 3, "Address", dt, "Cash");
            Assert.AreEqual(purchase.CalculateBillAmount(2690.0, 3), 7827.9);
        }
        [TestMethod]
        public void CalculateBillAmoountTest2()
        {
            DateTime dt = new DateTime(2019, 01, 15);
            Purchase purchase = new Purchase("1001", 3, "Address", dt, "Cash");
            Assert.AreEqual(purchase.CalculateBillAmount(-2690.0, 3), -7827.9);
        }
        [TestMethod]
        public void CalculateBillAmoountTest3()
        {
            DateTime dt = new DateTime(2019, 01, 15);
            Purchase purchase = new Purchase("1001", 3, "Address", dt, "Cash");
            Assert.AreEqual(purchase.CalculateBillAmount(0, 0), 0);
        }
    }
}
