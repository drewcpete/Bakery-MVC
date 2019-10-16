using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> vendors = Vendor.GetAll();
            return View(vendors);
        }        
        
        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpGet("/vendor/show")]
        {
            
        }
    }
}