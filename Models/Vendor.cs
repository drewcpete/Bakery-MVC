using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public List<Order> Orders { get; set; }
        private static List<Vendor> _vendors = new List<Vendor> {};
        public int VendorId { get; set; }


        public Vendor(string name, string description)
        {
            VendorName = name;
            VendorDescription = description;
            Orders = new List<Order> {};
            _vendors.Add(this);
            VendorId = _vendors.Count;
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public static Vendor Find(int Id)
        {
            return _vendors[Id - 1];
        }
        public static List<Vendor> GetAll()
        {
            return _vendors;
        }
    }
}
