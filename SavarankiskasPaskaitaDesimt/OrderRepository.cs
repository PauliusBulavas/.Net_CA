using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavarankiskasPaskaitaDesimt
{
    public class OrderRepository
    {
        private List<Order> Orders { get; set; } = new List<Order>();

        public Order GetById(int id)
        {
            var order = Orders.FirstOrDefault(x => x.Id == id);
            return order;
        }

        public bool SaveOrder(Order order)
        {
            Orders.Add(order);
            return true;
        }

        public int GetCount()
        {
            return Orders.Count;
        }

        public List<Order> Get()
        {
            return Orders;
        }


    }
}
