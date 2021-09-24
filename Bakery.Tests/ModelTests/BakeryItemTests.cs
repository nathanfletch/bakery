using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryItemTests : IDisposable
  {
    public void Dispose()
    {
      BakeryItem.ClearAll();
    }

    [TestMethod]
    public void GetOrderCost_ReturnsCostOfBreadOnly_10()
    {
      //arrange
      
      for(int i = 0; i < 3; i++)
      {
        Bread myLoaf = new Bread();
      }
      int expectedCost = 10;
      
      //act
      int result = BakeryItem.GetOrderCost();
      
      //assert
      Assert.AreEqual(expectedCost,result);
    }
    [TestMethod]
    public void GetOrderCost_ReturnsCostOfPastryOnly_5()
    {
      //arrange
      
      for(int i = 0; i < 3; i++)
      {
        Pastry myPastry = new Pastry();
      }
      int expectedCost = 5;

      //act
      int result = BakeryItem.GetOrderCost();
      
      //assert
      Assert.AreEqual(expectedCost,result);
    }
    [TestMethod]
    public void GetOrderCost_ReturnsCostOfBothTypes_15()
    {
      //arrange
      
      for(int i = 0; i < 3; i++)
      {
        Pastry myPastry = new Pastry();
      }
      for(int i = 0; i < 3; i++)
      {
        Bread myLoaf = new Bread();
      }
      int expectedCost = 15;

      //act
      int result = BakeryItem.GetOrderCost();
      
      //assert
      Assert.AreEqual(expectedCost,result);
    }
    [TestMethod]
    public void RemoveFromOrder_DecrementsCount_0()
    {
      //arrange
      
      Bread myLoaf = new Bread();
      int expectedCount = 0;
      string inputItemNumbers = "1";

      //act
      BakeryItem.RemoveFromOrder(inputItemNumbers);
      int result = BakeryItem.OrderItems.Count;
      
      //assert
      Assert.AreEqual(expectedCount,result);
    }
    [TestMethod]
    public void RemoveFromOrder_DecrementsCountBy2_0()
    {
      //arrange
      
      Bread myLoaf = new Bread();
      Bread myLoaf2 = new Bread();
      int expectedCount = 0;
      string inputItemNumbers = "1 2";

      //act
      BakeryItem.RemoveFromOrder(inputItemNumbers);
      int result = BakeryItem.OrderItems.Count;
      
      //assert
      Assert.AreEqual(expectedCount,result);
    }
  }
}