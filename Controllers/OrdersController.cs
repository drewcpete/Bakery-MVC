using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class BakeryController : Controller
    {
        
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost("/orders/show")]
        public ActionResult Show()
        {
          
        }

        [HttpGet("/orders/new")]
        public ActionResult Build()
        {
            return View();
        }
    }
    
}