using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendors = Vendor.GetAll();
            return View(vendors);
        }        
        
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderDescription, int orderPrice, string orderTitle, string orderDate)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderTitle, orderPrice, orderDate, orderDescription);
            foundVendor.AddOrder(newOrder);
            List<Order> vendorOrders = foundVendor.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", foundVendor);
            return View("Show", model);
        }
    }
}