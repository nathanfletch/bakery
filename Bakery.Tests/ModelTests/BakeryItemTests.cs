using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryItemTests
  {
    [TestMethod]
    public void GetOrderCost_ReturnsCostOfBreadOnly_10()
    {
      //arrange
      BakeryItem.OrderItems.Clear();
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
      BakeryItem.OrderItems.Clear();
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
      BakeryItem.OrderItems.Clear();
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
  }
}