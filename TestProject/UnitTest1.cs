using NUnit.Framework;
using PaskaitaDesimt;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameTestValid()
        {
            //arrange
            var customer = new Customer();

            customer.FirstName = "Jonas";
            customer.LastName = "Jonaitis";

            //gan dazna klaida jei be if checko luzta nes grazina null ir catastrophic failure
            if (customer.EmailAdress != null)
            {
                var email = customer.EmailAdress.ToLower();
            }
            //

            string expectedValue = "Jonas , Jonaitis";

            //act

            string actualValue = customer.GetFullName();

            //assert

            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void TestingStaticProperty()
        {
            //arrange
            var customer = new Customer();

            customer.FirstName = "Jonas";
            customer.LastName = "Jonaitis";
            //static tik per klase tiesiai eina pasiimti ir jis tik vienas, tad count po situ triju customer bus 3
            Customer.Count += 1;

            var customer1 = new Customer();

            customer.FirstName = "Jonas";
            customer.LastName = "Jonaitis";
            Customer.Count += 1;

            var customer2 = new Customer();

            customer.FirstName = "Jonas";
            customer.LastName = "Jonaitis";
            Customer.Count += 1;

            //act

            int expectedValue = 6;

            //assert
            Assert.AreEqual(expectedValue, Customer.Count);
        }

        [Test]
        public void TestingStaticCountMethod()
        {
            //arrange
            var customer = new Customer();

            customer.FirstName = "Jonas";
            customer.LastName = "Jonaitis";
            //static tik per klase tiesiai eina pasiimti ir jis tik vienas, tad count po situ triju customer bus 3
            Customer.Count += 1;

            var customer1 = new Customer();

            customer.FirstName = "Jonas";
            customer.LastName = "Jonaitis";
            Customer.Count += 1;

            var customer2 = new Customer();

            customer.FirstName = "Jonas";
            customer.LastName = "Jonaitis";
            Customer.Count += 1;

            //act

            string expectedValue = "3";

            //assert
            Assert.AreEqual(expectedValue, Customer.GetCountInString());
        }

        [Test]
        public void ValidateValid()
        {
            //taip galima inicijuoti irgi class
            var customer = new Customer
            {
                LastName = "Jonas",
                EmailAdress = "Jonas@gmail.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateMissingLastName()
        {
            //taip galima inicijuoti irgi class
            var customer = new Customer
            {
                EmailAdress = "Jonas@gmail.com"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SaveCustomer()
        {
            var customer = new Customer
            {
                LastName = "Jonas",
                EmailAdress = "Jonas@gmail.com"
            };
            var customer2 = new Customer
            {
                LastName = "Jonas",
                EmailAdress = "Jonas@gmail.com"
            };
            var customer3 = new Customer
            {
                LastName = "Jonas",
                EmailAdress = "Jonas@gmail.com"
            };

            var customerRepository = new CustomerRepository();

            customerRepository.SaveCustomer(customer);
            customerRepository.SaveCustomer(customer2);
            customerRepository.SaveCustomer(customer3);

            int expected = 3;

            Assert.AreEqual(expected, customerRepository.GetCount());
        }

        [Test]
        public void GetCustomerById()
        {
            var customer = new Customer
            {
                Id              = 1,
                LastName        = "Jonas",
                EmailAdress     = "Jonas@gmail.com"
            };
            var customer2 = new Customer
            {
                Id              = 2,
                LastName        = "Jonas",
                EmailAdress     = "Jonas@gmail.com"
            };
            var customer3 = new Customer
            {
                Id              = 3,
                LastName        = "Jonas",
                EmailAdress     = "Jonas@gmail.com"
            };

            var customerRepository = new CustomerRepository();

            customerRepository.SaveCustomer(customer);
            customerRepository.SaveCustomer(customer2);
            customerRepository.SaveCustomer(customer3);

            int expectedId  = 1;
            var actualCustomer    = customerRepository.GetById(1);

            Assert.AreEqual(expectedId, actualCustomer.Id);

        }

        private void GenerateCustomers()
        {
            var customer = new Customer
            {
                LastName = "Jonas",
                EmailAdress = "Jonas@gmail.com"
            };
            var customer2 = new Customer
            {
                LastName = "Jonas",
                EmailAdress = "Jonas@gmail.com"
            };
            var customer3 = new Customer
            {
                LastName = "Jonas",
                EmailAdress = "Jonas@gmail.com"
            };

            var customerRepository = new CustomerRepository();

            customerRepository.SaveCustomer(customer);
            customerRepository.SaveCustomer(customer2);
            customerRepository.SaveCustomer(customer3);
        }
    }
}