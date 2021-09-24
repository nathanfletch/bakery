using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      BakeryItem.ClearAll();
    }
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
    public void Constructor_AddsToOrder_1()
    {
      //arrange
      int expectedCount = 1;
      //act
      Pastry myPastry = new Pastry();
      int result = BakeryItem.GetCount();
      //assert
      Assert.AreEqual(expectedCount, result);
    }
    [TestMethod]
    public void Add_AddsPastriesToOrder_3()
    {
      //arrange
      int numToAdd = 3;
      //act
      Pastry.Add(numToAdd);
      int result = BakeryItem.GetCount();
      //assert
      Assert.AreEqual(numToAdd, result);
    }
    [TestMethod]
    public void NameGetter_ReturnsName_Pastry()
    {
      //arrange
      string expectedString = "Pastry";
      //act
      Pastry myPastry = new Pastry();
      string result = myPastry.Name;
      //assert
      Assert.AreEqual(expectedString, result);
    }
  }
}