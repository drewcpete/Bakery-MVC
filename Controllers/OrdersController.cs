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
        
        [HttpPost("/orders/show")]
        public ActionResult New()
        {
          
        }

        [HttpGet("/orders/new")]
        public ActionResult Build()
        {
            
            return View();
        }
    }
    
}