using System;
using System.Collections.Generic;


namespace CoffeeShop.Models
{
    public class Beverages
    {
        public int BeverageQuantity {get; set;} 
        public string BeverageType {get; set;}

        public Beverages (int beverageQuantity, string beverageType)
        {
            BeverageQuantity = beverageQuantity;
            BeverageType = beverageType; 
        }
        public int BeverageCost()
        {
            int beveragePrice = 3;
            int totalBeveragePrice = beveragePrice * BeverageQuantity;
            return totalBeveragePrice;
        }
        
    }

    public class Food
    {
        public int FoodQuantity {get; set;}
        public string FoodType {get; set;}

        public Food (int foodQuantity, string foodType)
        {
            FoodQuantity = foodQuantity;
            FoodType = foodType;
        }
        
        public int FoodCost()
        {
            int price = 3;
            int totalFoodPrice = price * FoodQuantity;
            return totalFoodPrice;
        }
    }
}


