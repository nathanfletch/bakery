using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      BakeryItem.ClearAll();
    }

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
    public void Constructor_AddsToOrder_1()
    {
      //arrange
      int expectedCount = 1;
      //act
      Bread myLoaf = new Bread();
      int result = BakeryItem.GetCount();
      //assert
      Assert.AreEqual(expectedCount, result);
    }
    [TestMethod]
    public void Add_AddsLoavesToOrder_3()
    {
      //arrange
      int numToAdd = 3;
      //act
      Bread.Add(numToAdd);
      int result = BakeryItem.GetCount();
      //assert
      Assert.AreEqual(numToAdd, result);
    }

    [TestMethod]
    public void NameGetter_ReturnsName_Bread()
    {
      //arrange
      string expectedString = "Bread";
      //act
      Bread myLoaf = new Bread();
      string result = myLoaf.Name;
      //assert
      Assert.AreEqual(expectedString, result);
    }
  }
}
