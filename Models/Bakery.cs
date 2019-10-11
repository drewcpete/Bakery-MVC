using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string VendorName {get; set;}
        public string Description {get; set;}
        public List<Order> Orders {get; set;}
        private static List<Vendor> _vendors = new List<Vendor> {};


        public Vendor(string name, string description)
        {
            VendorName = name;
            Description = description;
            Orders = new List<Order> ();
            _vendors.Add(this);
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

    }

    public class Order
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public string OrderDescription {get; set;}

        public Order(string title, int price, string date, string orderDescription)
        {
            Title = title;
            Price = price;
            Date = date;
            OrderDescription = orderDescription;
        }

    }
}

