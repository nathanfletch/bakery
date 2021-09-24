using System.Collections.Generic;

namespace Bakery
{
  public class Pastry : BakeryItem
  {
    public Pastry()
    {
      BakeryItem.OrderItems.Add(this);
    }

    public static int CalculateCost(int pastries)
    {
      int totalCost = 0;
      for (int pastryNumber = 1; pastryNumber <= pastries; pastryNumber++)
      {
        if(pastryNumber % 3 != 0)
        {
          totalCost += 2;
        }
        else
        {
          totalCost += 1;
        }
      }
      return totalCost;
    }
  }
}