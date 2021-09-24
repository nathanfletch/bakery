using System.Collections.Generic;

namespace Bakery
{
  public class Pastry
  {
    public static int CalculateCost(int pastries)
    {
      int totalCost = 0;
      totalCost += pastries * 2;
      return totalCost;
    }
  }
}
      // for (int pastryNumber = 1; pastryNumber <= pastries; pastryNumber++)
      // {
      //   if(pastryNumber % 3 != 0)
      //   {
      //     totalCost += 5;
      //   }
      // }