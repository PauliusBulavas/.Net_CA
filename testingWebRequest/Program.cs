using System;
using System.Globalization;
using System.Text;
using System.Xml;

namespace CurrencyCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string fromCurrency = "EUR";
            string toCurrency = "";
            int amount = 1;

            PrintAllCurrencyCodes();

            Console.WriteLine("Insert currency you want to exchange EUR to:");
            toCurrency = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Insert currency amount:");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            double exchangeRate = GetExchangeRate(fromCurrency, toCurrency, amount);

            Console.WriteLine("FROM " + amount + " " + fromCurrency.ToUpper() + " TO " + toCurrency.ToUpper() + " = " + exchangeRate);

            Console.ReadLine();

        }

        static void PrintAllCurrencyCodes()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            StringBuilder sb = new StringBuilder();
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                sb.Append($"{xmlNode.Attributes["currency"].Value} ");
            }
            Console.WriteLine(sb.ToString());

        }

        static double GetExchangeRate(string from, string to, float amount)
        {
            if (to == null)
                return 0;

            if (to.ToLower() == "eur")
                return amount;

            try
            {
                double toRate = GetCurrencyRateInEuro(to);

                return amount * toRate;

            }
            catch
            {
                return 0;
            }
        }

        static double GetCurrencyRateInEuro(string currency)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");

            XmlNodeList itemNodes = xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes;

            foreach (XmlNode node in itemNodes)
            {
                try
                {
                    var responseCurrency = node.Attributes["currency"];

                    if (responseCurrency.Value.ToLower() != currency)
                    {
                        continue;
                    }

                    IFormatProvider provider = NumberFormatInfo.InvariantInfo;

                    var responseRate = node.Attributes["rate"];
                    return double.Parse(responseRate.Value, provider);
                }
                catch { }
            }
            return 0;
        }

    }
}
