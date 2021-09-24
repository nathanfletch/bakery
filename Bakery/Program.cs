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
      Console.WriteLine($"Your order: ");
      for (int i = 0; i < BakeryItem.OrderItems.Count; i++)
      {
        Console.WriteLine($"{i + 1}: {BakeryItem.OrderItems[i].Name}");
      }
      Console.WriteLine($"Total: ${BakeryItem.GetOrderCost()}.");
    }

    void AskWhetherToModify()
    {
      Console.WriteLine($"Would you like to add to your order? (Y/N)");
      string input = Console.ReadLine();
      if(input.ToLower() == "y")
      {
        InteractWithCustomer();
      }
      else
      {
        Console.WriteLine($"Thanks for visiting Nathan's! Come back anytime!");
      }
    }
  }
}