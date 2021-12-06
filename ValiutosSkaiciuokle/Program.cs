using System;

namespace ValiutosSkaiciuokle
{
    /// <summary>
    /// Money Converter
    /// </summary>
    class Program
    {
        private static string[] currencyNames = { "EUR", "USD", "PLN", "BYR" }; 

        private static readonly decimal[] currencyValues = { 1.00m, 1.13m, 4.59m, 2.87m };
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = OptionSelectionMenu();
            }
        }

        private static bool OptionSelectionMenu()
        {
            Console.WriteLine("Money Converter");
            Console.WriteLine("\nconevert EUR to:\n");
            Console.WriteLine("[1] - USD");
            Console.WriteLine("[2] - PLN");
            Console.WriteLine("[3] - BYR");
            Console.WriteLine("[4] - Exit");


            switch (Console.ReadLine())
            {
                case "1":
                    Converter(1, 1);
                    return true;

                case "2":
                    Converter(2, 2);
                    return true;

                case "3":
                    Converter(3, 3);
                    return true;

                case "4":
                    return false;

                default:
                    return true;

            }
        }

        private static void Converter(int Names, int Values)
        {
            Console.Write("Input the ammount of EUR you want to convert: ");
            decimal ammount = decimal.Parse(Console.ReadLine());
            string name = Convert.ToString(currencyNames.GetValue(Names));
            decimal value = Convert.ToDecimal(currencyValues.GetValue(Values));
            Console.WriteLine($"The exchange rate of {name} is {value}");

            Console.WriteLine($"{ammount} EUR is {value * ammount} {name}");
            Console.ReadKey();

        }



    }
}
