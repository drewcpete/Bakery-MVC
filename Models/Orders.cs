using System.Collections.Generic;

namespace Bakery.Models
{   
    public class Order
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public string OrderDescription { get; set; }
        public int Id {get; set;}
        private static List<Order> _orders = new List<Order> {};


        public Order(string title, int price, string date, string orderDescription)
        {
            Title = title;
            Price = price;
            Date = date;
            OrderDescription = orderDescription;
            _orders.Add(this);
            Id = _orders.Count;
        }

        public static List<Order> GetAll()
        {
            return _orders;
        }

    }
}

