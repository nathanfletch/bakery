using System;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine($"Welcome to Nathan's Bakery!");
    
    Console.WriteLine($"Today's deals:");
    Console.WriteLine($"Bread: $5 a loaf. Buy 2 get 1 free!");
    Console.WriteLine($"Pastries: $2 each. Buy 2 get 1 half off!");

    SellBread();
    SellPastries();
    DisplayOrder();

    // void AddToOrder()
    void SellBread()
    {
      Console.WriteLine($"How many loaves would you like to buy?");
      int loavesInput = int.Parse(Console.ReadLine());
      Bread.Add(loavesInput);
    }

    void SellPastries()
    {
      Console.WriteLine($"How many pastries would you like to buy?");
      int pastriesInput = int.Parse(Console.ReadLine());
      Pastry.Add(pastriesInput);
    }  

    void DisplayOrder()
    {
      //Display items: 
      Console.WriteLine($"Your order: ");
      foreach (BakeryItem item in BakeryItem.OrderItems)
      {
        Console.WriteLine($"{item.GetType()}");
      }
      Console.WriteLine($"Total: ${BakeryItem.GetOrderCost()}.");
    }


    
  }
}