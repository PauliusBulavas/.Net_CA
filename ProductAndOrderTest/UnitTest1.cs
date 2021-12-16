using NUnit.Framework;
using SavarankiskasPaskaitaDesimt;

namespace ProductAndOrderTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void saveProduct()
        {
            var product = new Product
            {
                ProductName = "kirvis",
                Description = "Fiskars"
            };
            var product1 = new Product
            {
                ProductName = "kirvis",
                Description = "Fiskars"
            };
            var product2 = new Product
            {
                ProductName = "kirvis",
                Description = "Fiskars"
            };

            var productRepository = new ProductRepository();

            productRepository.SaveProduct(product);
            productRepository.SaveProduct(product1);
            productRepository.SaveProduct(product2);

            int expected = 3;

            Assert.AreEqual(expected, productRepository.GetCount());
        }

        [Test]
        public void saveOrder()
        {
            var order = new Order
            {
                Id = 1,   
            };
            var order1 = new Order
            {
                Id = 1,
            };
            var order2 = new Order
            {
                Id = 1,
            };

            var orderRepository = new OrderRepository();

            orderRepository.SaveOrder(order);
            orderRepository.SaveOrder(order1);
            orderRepository.SaveOrder(order2);

            int expected = 3;

            Assert.AreEqual(expected, orderRepository.GetCount());
        }

        [Test]
        public void GetOrderById()
        {
            var order = new Order
            {
                Id = 1,
            };
            var order1 = new Order
            {
                Id = 2,
            };
            var order2 = new Order
            {
                Id = 3,
            };

            var orderRepository = new OrderRepository();

            orderRepository.SaveOrder(order);
            orderRepository.SaveOrder(order1);
            orderRepository.SaveOrder(order2);

            int expectedId = 1;
            var actualOrder = orderRepository.GetById(1);

            Assert.AreEqual(expectedId, actualOrder.Id);

        }

        [Test]
        public void GetProductById()
        {
            var product = new Product
            {
                Id          = 1,
                ProductName = "kirvis",
                Description = "Fiskars"
            };
            var product1 = new Product
            {
                Id          = 2,
                ProductName = "kirvis",
                Description = "Fiskars"
            };
            var product2 = new Product
            {
                Id          = 3,
                ProductName = "kirvis",
                Description = "Fiskars"
            };

            var productRepository = new ProductRepository();

            productRepository.SaveProduct(product);
            productRepository.SaveProduct(product1);
            productRepository.SaveProduct(product2);

            int expectedId = 1;
            var actualProduct = productRepository.GetById(1);

            Assert.AreEqual(expectedId, actualProduct.Id);

        }

        private void SaveOreders()
        {

        }
        private void SaveProducts()
        {

        }
    }
}