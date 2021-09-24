using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public abstract class BakeryItem 
  {
    public static List<BakeryItem> OrderItems {get;} = new List<BakeryItem>();

    public abstract string Name {get;}

    public static int GetOrderCost()
    {
      
      int numLoaves = 0;
      int numPastries = 0;
      foreach (BakeryItem item in OrderItems)
      {
        if(item.GetType() == typeof(Bread))
        {
          numLoaves++;
        }
        else
        {
          numPastries++;
        }
      }
      return Bread.CalculateCost(numLoaves) + Pastry.CalculateCost(numPastries);
    }

    public static void RemoveFromOrder(string itemsToRemove)
    {
      string[] itemStrings = itemsToRemove.Split(' ');
      int[] itemInts = Array.ConvertAll(itemStrings, int.Parse);

      for (int i = itemInts.Length - 1; i >= 0; i--)
      {
        BakeryItem.OrderItems.RemoveAt(itemInts[i] - 1);
      }    
    }
  }
}