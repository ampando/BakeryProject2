using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Order", "Test Description", 50, "Test Date", "Test Frequency");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Test Description", 50, "Test Date", "Test Frequency");

        string result = newOrder.Title;

        Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string description = "Test Description";
      Order newOrder = new Order("Test Order", description, 50, "Test Date", "Test Frequency");

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      double price = 50.00;
      Order newOrder = new Order("Test Order", "Test Description", price, "Test Date", "Test Frequency");

      double result = newOrder.Price;

      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsOrderDate_Int()
    {
      string date = "July 15, 2022";
      Order newOrder = new Order("Test Order", "Test Description", 50, date, "Test Frequency");
    
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void GetFrequency_ReturnsOrderFrequency_String()
    {
      string frequency = "Twice a week, Tuesday and Thursday";
      Order newOrder = new Order("Test Order", "Test Description", 50, "July 15,2020", frequency);

      string result = newOrder.Frequency;

      Assert.AreEqual(frequency, result);
    }
    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      Order newOrder = new Order("Test Order", "Test Description", 50, "July 15,2022","Twice a week, Tuesday and Thursday");

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
    }
  }
