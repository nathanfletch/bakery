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
    [TestMethod]
    public void CalculateCost_ReturnsCostOf3_10()
    {
      //arrange
      int expectedCost = 10;
      int numberOfLoaves = 3;
      //act
      int result = Bread.CalculateCost(numberOfLoaves);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCostOf4_15()
    {
      //arrange
      int expectedCost = 15;
      int numberOfLoaves = 4;
      //act
      int result = Bread.CalculateCost(numberOfLoaves);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCostOf6_20()
    {
      //arrange
      int expectedCost = 20;
      int numberOfLoaves = 6;
      //act
      int result = Bread.CalculateCost(numberOfLoaves);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCostOf0_0()
    {
      //arrange
      int expectedCost = 0;
      int numberOfLoaves = 0;
      //act
      int result = Bread.CalculateCost(numberOfLoaves);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void Constructor_AddsToOrder_OrderCount1()
    {
      //arrange
      int expectedCount = 1;
      //act
      Bread myLoaf = new Bread();
      int result = BakeryItem.OrderItems.Count;
      //assert
      Assert.AreEqual(expectedCount, result);
    }
  }
    /*
    Test and implement Bread CalculateCost(int n) static fn
    Test and implement Pastry CalculateCost(int n) static fn
    
    Add abstract class BakeryItem
    test/imp constructors
    static list: order 

    calc/disp order cost GetOrderCost
      use GetType and call each classes' method.
    UI!
    */
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalculateCost_ReturnsCost_2()
    {
      //arrange
      int expectedCost = 2;
      int numberOfPastries = 1;
      //act
      int result = Pastry.CalculateCost(numberOfPastries);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCost_5()
    {
      //arrange
      int expectedCost = 5;
      int numberOfPastries = 3;
      //act
      int result = Pastry.CalculateCost(numberOfPastries);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCost_0()
    {
      //arrange
      int expectedCost = 0;
      int numberOfPastries = 0;
      //act
      int result = Pastry.CalculateCost(numberOfPastries);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCost_10()
    {
      //arrange
      int expectedCost = 10;
      int numberOfPastries = 6;
      //act
      int result = Pastry.CalculateCost(numberOfPastries);
      //assert
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void Constructor_AddsToOrder_OrderCount1()
    {
      //arrange
      int expectedCount = 1;
      //act
      Pastry myPastry = new Pastry();
      int result = BakeryItem.OrderItems.Count;
      //assert
      Assert.AreEqual(expectedCount, result);
    }
  }
}