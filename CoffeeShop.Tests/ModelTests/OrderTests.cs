using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CoffeeShop.Models;

namespace CoffeeShop.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void BeveragesConstructor_CreatesInstancesofBeverage_Beverages()
        {
        Beverages newBeverages = new Beverages();
        Assert.AreEqual(typeof(Beverages), newBeverages.GetType());
        }    
    }

}