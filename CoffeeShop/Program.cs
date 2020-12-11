using System;
using System.Collections.Generic;
using CoffeeShop.Models;

namespace CoffeeShop
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("what beverage will you be having?");
            string drinkOrder = Console.ReadLine();
            Console.WriteLine("how many would you like?");
            string stringDrinkQuantity = Console.ReadLine();
            int drinkQuantity = int.Parse(stringDrinkQuantity);
            Console.WriteLine("what snack would you like?");
            string foodOrder = Console.ReadLine();
            Console.WriteLine("how many food would you like?");
             string stringFoodQuantity = Console.ReadLine();
            int foodQuantity = int.Parse(stringFoodQuantity);
            Beverages userBeverages = new Beverages(drinkQuantity, drinkOrder);
            Food userFood = new Food(foodQuantity, foodOrder);
            int totalOrder = userBeverages.BeverageCost() + userFood.FoodCost();
            string message = $"You ordered:  {drinkOrder} and {foodOrder}";
            Console.WriteLine(message);
            string cost = $"Your total is: {totalOrder}";
            Console.WriteLine(cost);
        }
    }
}