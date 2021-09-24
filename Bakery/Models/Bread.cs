using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : BakeryItem
  {
    public Bread()
    {
      BakeryItem.OrderItems.Add(this);
    }

    public static int CalculateCost(int loaves)
    {
      int totalCost = 0;
      for (int loafNumber = 1; loafNumber <= loaves; loafNumber++)
      {
        if(loafNumber % 3 != 0)
        {
          totalCost += 5;
        }
      }
      return totalCost;
    }
  }
}