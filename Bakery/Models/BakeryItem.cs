using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public abstract class BakeryItem 
  {
    protected static List<BakeryItem> _orderItems = new List<BakeryItem>();

    public abstract string Name {get;}

    public static string GetOrderDisplay() {
      string displayString = "Take a look at your order:";
      for (int i = 0; i < _orderItems.Count; i++)
      {
        displayString += $"\n{i + 1}: {_orderItems[i].Name}";
      }
      return displayString;
    }

    public static int GetOrderCost()
    {
      int numLoaves = 0;
      int numPastries = 0;
      foreach (BakeryItem item in _orderItems)
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

      //reverse order to avoid index out of range errors
      for (int i = itemInts.Length - 1; i >= 0; i--)
      {
        BakeryItem._orderItems.RemoveAt(itemInts[i] - 1);
      }    
    }

    public static void ClearAll()
    {
      _orderItems.Clear();
    }

    public static int GetCount()
    {
      return _orderItems.Count;
    }
  }
}