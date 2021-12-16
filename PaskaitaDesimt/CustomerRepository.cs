using System.Collections.Generic;
using System.Linq;

namespace PaskaitaDesimt
{
    public class CustomerRepository
    {
        private List<Customer> Customers { get; set; } = new List<Customer>();

        public bool SaveCustomer(Customer customer)
        {
            Customers.Add(customer);
            return true;
        }

        public Customer GetById(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public List<Customer> Get()
        {
            return Customers;
        }

        public int GetCount()
        {
            return Customers.Count;
        }
    }
}
