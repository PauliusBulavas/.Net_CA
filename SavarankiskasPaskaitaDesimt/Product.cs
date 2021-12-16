using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasPaskaitaDesimt
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }

        public Product() { }
           
        //public bool Validate()
        //{
        //    var isValid = true;

        //    if (string.IsNullOrWhiteSpace(ProductName))
        //    {
        //        isValid = false;
        //    }
        //    if (string.IsNullOrWhiteSpace(Description))
        //    {
        //        isValid = false;
        //    }

        //    return isValid;
        //}

        //public bool Save()
        //{
        //    return true;
        //}

        //public List<Product> Retrieve()
        //{
        //    return new List<Product>(); ;
        //}

        //public Product Retrieve(int productId)
        //{
        //    return new Product();
        //}


    }
}
