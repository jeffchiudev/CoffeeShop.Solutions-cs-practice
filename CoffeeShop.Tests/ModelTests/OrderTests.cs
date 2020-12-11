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
        public void BeveragesConstructor_CreatesInstanceofBeverage_Beverages()
        {
        Beverages newBeverages = new Beverages(1, 2);
        Assert.AreEqual(typeof(Beverages), newBeverages.GetType());
        } 
        
        [TestMethod]
        public void FoodConstructor_CreatesInstanceofFood_Food()
        {
        Food newFood = new Food(1, 2);
        Assert.AreEqual(typeof(Food), newFood.GetType());
        }    
    }

}