using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class OrderController : Controllers
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      return View(selectedVendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order selectedOrder = Order.Find(orderId);
      Vendor selectedVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", selectedOrder);
      model.Add("vendor", selectedVendor);
      return View(model);
    }
  }
}