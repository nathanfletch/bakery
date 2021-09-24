using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateCost_ReturnsCost_5()
    {
      //arrange
      int expectedCost = 5;
      int numberOfLoaves = 1;
      //act
      int result = Bread.CalculateCost(numberOfLoaves);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCost_10()
    {
      //arrange
      int expectedCost = 10;
      int numberOfLoaves = 2;
      //act
      int result = Bread.CalculateCost(numberOfLoaves);
      //assert
      Assert.AreEqual(expectedCost, result);
    }

    /*
    Test and implement Bread CalculateCost(int n) static fn
    Test and implement Pastry CalculateCost(int n) static fn
    
    Add abstract class BakeryItem
    test/imp constructors
    static list: order 

    add fn
    calc/disp order cost GetOrderCost
      use GetType and call each classes' method.
    UI!

  





    Bread
    Pastry 
    */


  }
}