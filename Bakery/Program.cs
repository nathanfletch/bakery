using System;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine($"Welcome to Nathan's Bakery!");
    
    Console.WriteLine($"Today's deals:");
    Console.WriteLine($"Bread: 5$ a loaf. Buy 2 get 1 free!");
    Console.WriteLine($"Pastries: 2$ each. Buy 2 get 1 half off!");
    Console.WriteLine($"How many loaves would you like to buy? Enter a number to add to order: ");
    int loavesInput = int.Parse(Console.ReadLine());
    Console.WriteLine($"Your order: {loavesInput} loaves.");
    
    // need an addLoaves function
    // for()
    
    
    
    
  }
}