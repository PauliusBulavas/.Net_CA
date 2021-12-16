using System;
using System.Collections.Generic;
using System.Text;

namespace PaskaitaDesimt
{
    public class Customer
    {
        public int    Id            { get; set; }
        public string FirstName     { get; set; }
        public string LastName      { get; set; }
        public string FullName      { get; set; }
        public string EmailAdress   { get; set; }
        public string HomeAdress    { get; set; }
        public string WorkAdress    { get; set; }

        public static int Count     { get; set; }

        public Customer(){ }

        public Customer(string firstName, string lastName)
        {
            FirstName   =   firstName;
            LastName    =   lastName;
        }

        public Customer(string firstName, string lastName, string emailAdress)
        {
            FirstName   =   firstName;
            LastName    =   lastName;
            EmailAdress =   emailAdress;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAdress))
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// sita klase neturetu daryti tokiu metodu, jie turetu buti iskelti
        /// </summary>


        //public bool Save()
        //{
        //    //cutomer repo butu kita class
        //    //CustomerRepository.Save(Customer cutomer);
        //    return true;
        //}

        //public Customer Retrieve(int customerId)
        //{
        //    //CustomerRepository.GetById(customerId);
        //    return new Customer();
        //}

        //public List<Customer> Retrieve()
        //{
        //    //CustomerRepository.GetAllCustomers();
        //    return new List<Customer>();
        //}

        public string GetFullName()
        {
            return FirstName + " , " + LastName;
        }

        public static string GetCountInString()
        {
            return Count.ToString();
        }

    }
}
