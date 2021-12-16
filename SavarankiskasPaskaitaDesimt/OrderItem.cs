using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasPaskaitaDesimt
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (ProductId == 0)
            {
                isValid = false;
            }
            if (PurchasePrice == 0)
            {
                isValid = false;
            }

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
    }
}
