using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasPaskaitaDesimt
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Order() { }

        //public bool Validate()
        //{
        //    var isValid = true;

        //    if (Id == 0)
        //    {
        //        isValid = false;
        //    }

        //    return isValid;
        //}

        //public bool Save()
        //{
        //    return true;
        //}

        //public List<Order> Retrieve()
        //{
        //    return new List<Order>();
        //}

        //public Order Retrieve(int orderId)
        //{
        //    return new Order();
        //}
    }
}
