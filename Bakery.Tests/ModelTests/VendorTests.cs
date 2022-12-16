using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVender = new Vendor("testName", "testInfo");
      Assert.AreEqual(typeof(Vendor), newVender.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVender1 = new Vendor("testName", "testInfo");
      Vendor newVender2 = new Vendor("testName", "testInfo");
      int result = newVender2.Id;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendorObjects_List()
    {
      Vendor newVender1 = new Vendor("testName", "testInfo");
      Vendor newVender2 = new Vendor("testName", "testInfo");
      List<Vendor> vendorList = new List<Vendor> { newVender1, newVender2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVender1 = new Vendor("testName", "testInfo");
      Vendor newVender2 = new Vendor("testName", "testInfo");
      List<Vendor> vendorList = new List<Vendor> { newVender1, newVender2 };
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVender2, result);
    }

    [TestMethod]
    public void AddOrder_CreatesOrderWithinVendor_OrderList()
    {
      Order newOrder = new Order("test", "test", "test", 2, 1);
      List<Order> newList = new List<Order> {newOrder};
      Vendor newVendor = new Vendor("testName", "testInfo");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
