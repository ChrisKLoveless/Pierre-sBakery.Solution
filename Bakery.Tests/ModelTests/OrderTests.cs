using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetTotalPrice_ReturnsTotalPrice_Int()
    {
      Order newOrder = new Order("test", "test", "test", 2, 1);
      Assert.AreEqual(2, newOrder.TotalPrice);
    }

    [TestMethod]
    public void GetOrders_ReturnsListofOrders_OrderList()
    {
      Order newOrder1 = new Order("test", "test", "test", 2, 1);
      Order newOrder2 = new Order("test", "test", "test", 2, 1);
      List<Order> orderList = new List<Order>{ newOrder1, newOrder2 };
      List<Order> result = Order.GetOrders();

      CollectionAssert.AreEqual(result, orderList);
    }
  }
}