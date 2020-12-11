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
        public void BeveragesConstructor_CreatesInstanceofBeverage_Constructor()
        {
            Beverages newBeverages = new Beverages(1, "coffee");
            Assert.AreEqual(typeof(Beverages), newBeverages.GetType());
        } 
        
        [TestMethod]
        public void FoodConstructor_CreatesInstanceofFood_Constructor()
        {
            Food newFood = new Food(1, "doughnut");
            Assert.AreEqual(typeof(Food), newFood.GetType());
        }    

        [TestMethod]
        public void BeverageConstructor_GetsPrice_Int()
        {   //Arrange
            int inputBeverageQuantity = 3;
            string inputBeverageType = "tea";
            int beverageResult = 9;
            Beverages newBevOrder = new Beverages(inputBeverageQuantity, inputBeverageType);
            //Act 
            int beverageCost = newBevOrder.BeverageCost();
            //Assert
            Assert.AreEqual(beverageResult, beverageCost);
        }
        
        [TestMethod]
        public void FoodConstructor_GetsPrice_Int()
        {
            int inputFoodQuantity = 3;
            string inputFoodType = "baguette";
            int foodResult = 9;
            Food newFoodOrder = new Food(inputFoodQuantity, inputFoodType);
            int foodCost = newFoodOrder.FoodCost();
            Assert.AreEqual(foodResult, foodCost);
        }
    }

}
