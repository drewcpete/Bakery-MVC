using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Orders> Orders {get; set;}
    }
}