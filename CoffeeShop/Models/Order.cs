using System;
using System.Collections.Generic;


namespace CoffeeShop.Models
{
    public class Beverages
    {
        public int BeverageQuantity {get; set;} 
        public int BeverageTotal {get; set;}

        public Beverages (int beverageQuantity, int beverageTotal)
        {
            // BeverageQuantity = beverageQuantity;
            // BeverageTotal = beverageTotal;
        }
    
    }

    public class Food
    {
        public int FoodQuantity {get; set;}
        public int FoodTotal {get; set;}

        public Food (int foodQuantity, int foodTotal)
        {
            // FoodQuantity = foodQuantity;
            // FoodTotal = foodTotal;
        }
    }
}


