using System;
using System.Collections.Generic;

namespace Bakery.Models
{   
    public class Order
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public string OrderDescription {get; set;}
        // public int Id {get; set;}
        public int TotalBread { get; set; }
        public int TotalPastry { get; set; }
        public Order(string title, int price, string date, string orderDescription, int bread, int pastry)
        {
            Title = title;
            Price = price;
            Date = date;
            OrderDescription = orderDescription;
        }

    }
}

