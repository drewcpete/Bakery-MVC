using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class BakeryController : Controller
    {
        
        [HttpGet("/vendor/{vendorId}/show")]
        public ActionResult Show(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }
        
        // [HttpPost("/orders/{orderId}/")]
        // public ActionResult Create()
        // {
        //     Vendor vendor = new Vendor;

        //     return View()
        // }

        [HttpGet("/orders/new")]
        public ActionResult New()
        {

            return View();
        }
    }
    
}