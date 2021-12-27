using HTML_Generator;
using SavarankiskasAirGenerator.Repositories;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SavarankiskasAirGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var htmlFormatter = new HTMLGenerator();

            var aircraftModelRepo = new AircraftModelRepository();
            var aircraftRepo = new AircraftRepository();
            var companyRepo = new CompanyRepository();
            var countryRepo = new CountryRepository();

            var report = new ReportGenerator(aircraftModelRepo, aircraftRepo, companyRepo, countryRepo);
            var result = report.GenerateReportAircraftInEurope();
            //var result = report.GenerateReportAircraftOtherContinents();

            var html = htmlFormatter.FormatHTML(result);

            Console.WriteLine(html);

            #region
            //var htmlFormatter = new HTMLGenerator();

            //var reportItem = new List<ReportItem>
            //{
            //    new ReportItem
            //    {
            //        TailNumberOfAircraft = "TEST",
            //        ModelOfAircarft = "TEST",
            //        ModelDescription = "TEST",
            //        CompanyOfAircraft = "TEST",
            //        CountryCode = "TEST",
            //        CountryName = "TEST",
            //        IsPartOfEU = true
            //    },
            //    new ReportItem
            //    {
            //        TailNumberOfAircraft = "TEST2",
            //        ModelOfAircarft = "TEST2",
            //        ModelDescription = "TEST2",
            //        CompanyOfAircraft = "TEST2",
            //        CountryCode = "TES2T",
            //        CountryName = "TEST2",
            //        IsPartOfEU = false
            //    }
            //};

            //var result = htmlFormatter.FormatHTML(new List<ReportItem>());

            //Console.WriteLine(result);
            #endregion

            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("9d202db04bde90", "4df8b9a9255614"),
                EnableSsl = true
            };
            client.Send("pauliusbulavas@gmail.com", "pauliusbulavas@gmail.com", "report", html);
            Console.WriteLine("Sent");
            Console.ReadLine();
        }
    }
}
