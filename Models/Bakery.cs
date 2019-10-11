using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Order> Orders {get; set;}

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            Orders = new List<Order> ();
        }
    }

    public class Order
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

        public Order(string title, DateTime date)
        {
            Title = title;
            Price = 0;
            Date = date;
        }
    }
}

