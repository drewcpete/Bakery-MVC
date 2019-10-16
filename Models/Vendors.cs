using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }
        private static List<Vendor> _vendors = new List<Vendor> { };
        public int Id { get; set; }


        public Vendor(string name, string description)
        {
            VendorName = name;
            Description = description;
            Orders = new List<Order> { };
            _vendors.Add(this);
            Id = _vendors.Count;
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
