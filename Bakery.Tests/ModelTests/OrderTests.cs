using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests 
  {
    [TestMethod]
    public void Constructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", 1, 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      Order newOrder = new Order("test", "test", "test", 1, 1);
      Assert.AreEqual(1, newOrder.Id);
    }
  }
}