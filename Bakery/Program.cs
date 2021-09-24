using System;
using System.Collections.Generic;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine($"Welcome to Nathan's Bakery!");
    
    Console.WriteLine($"Today's deals:");
    Console.WriteLine($"Bread: $5 a loaf. Buy 2 get 1 free!");
    Console.WriteLine($"Pastries: $2 each. Buy 2 get 1 half off!");
    
    InteractWithCustomer();

    void InteractWithCustomer()
    {
      SellBread();
      SellPastries();
      DisplayOrder();
      AskWhetherToModify();
    }

    void SellBread()
    {
      Console.WriteLine($"How many loaves would you like to add to your order?");
      int loavesInput = int.Parse(Console.ReadLine());
      Bread.Add(loavesInput);
    }

    void SellPastries()
    {
      Console.WriteLine($"How many pastries would you like to add to your order?");
      int pastriesInput = int.Parse(Console.ReadLine());
      Pastry.Add(pastriesInput);
    }  

    void DisplayOrder()
    {
      Console.WriteLine($"Take a look at your order: ");
      for (int i = 0; i < BakeryItem.OrderItems.Count; i++)
      {
        Console.WriteLine($"{i + 1}: {BakeryItem.OrderItems[i].Name}");
      }
      Console.WriteLine($"Total: ${BakeryItem.GetOrderCost()}.");
    }

    void AskWhetherToModify()
    {
      Console.WriteLine($"Everything look ok? Press A to add items, R to remove items, or C to checkout.");
      string inputOption = Console.ReadLine().ToUpper();
      if(inputOption == "A")
      {
        InteractWithCustomer();
      } 
      else if (inputOption == "R")
      {
        Console.WriteLine($"Enter the item numbers (separated by one space) you would like to remove:");
        string itemsToRemove = Console.ReadLine();
        BakeryItem.RemoveFromOrder(itemsToRemove);
        DisplayOrder();
        AskWhetherToModify();
      }
      else
      {
        Console.WriteLine($"Thanks for visiting Nathan's! Come back anytime!");
      }
    }
  }
}