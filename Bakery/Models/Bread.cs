using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : BakeryItem
  {
    public override string Name
    {
        get
        {
            return "Bread";
        }
    }

    public Bread()
    {
      BakeryItem._orderItems.Add(this);
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

    public static void Add(int numLoaves)
    {
      for(int i = 0; i < numLoaves; i++)
      {
        Bread anonymousLoaf = new Bread();
      }
    }
  }
}