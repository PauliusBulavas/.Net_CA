using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavarankiskasPaskaitaDesimt
{
    public class ProductRepository
    {
        private List<Product> Products { get; set; } = new List<Product>();

        public Product GetById(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public bool SaveProduct(Product product)
        {
            Products.Add(product);
            return true;
        }

        public int GetCount()
        {
            return Products.Count;
        }

        public List<Product> Get()
        {
            return Products;
        }
    }
}
