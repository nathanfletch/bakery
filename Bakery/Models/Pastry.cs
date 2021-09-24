using System.Collections.Generic;

namespace Bakery.Models
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

    public static void Add(int numPastries)
    {
      for(int i = 0; i < numPastries; i++)
      {
        Pastry anonymousPastry = new Pastry();
      }
    }
  }
}