using System;

namespace PaskaitaDesimt
{
    class Program
    {
        static void Main(string[] args)
        {
            //NO PARAMETER CONSTRUCTOR
            //be constructor
            var customer    =   new Customer();

            customer.FirstName  =   "Jonas";
            customer.LastName   =   "Jonaitis";

            //PARAMETER CONSTRUCTOR
            //pagal constructoriu
            var customerTwo = new Customer("Petras", "Petrauskas");

            int x;
            x = 10;

            int y = x;
            y = 100;

            //class yra reference tipo tai objektai keicia vienas kita
            var customer1 = new Customer();
            customer.FirstName = "Jonas";

            var customer2 = customer1;
            customer2.FirstName = "Petras";

            //inheritance paveldima tik is vienos klases

            var zinduolis = new Zinduolis();
            var kate = new Kate();
            var zuvis = new Zuvis();
        }
    }
}
