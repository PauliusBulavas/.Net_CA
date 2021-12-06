using System;
using System.Collections.Generic;
using System.Linq;

namespace BilietavimoSistema
{
    /// <summary>
    /// Bilietavimo Sistema
    /// </summary>

    class Program
    {
        private static int ticketTenSellCreate = 0;
        private static int ticketTwentySellCreate = 0;
        private static int ticketThirtySellCreate = 0;

        private static int totalTenSold = 0;
        private static int totalTwentySold = 0;
        private static int TotalThirtySold = 0;

        private static int totalTenCreated = 0;
        private static int totalTwentyCreated = 0;
        private static int TotalThirtyCreated = 0;


        static void Main(string[] args)
        {
            bool showMenu = true;           
            while (showMenu)
            {
                showMenu = OptionSelectionMenu();

                try
                {
                       

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured: {e.Message}");
                }
            }


        }

        private static bool OptionSelectionMenu()
        {
            Console.WriteLine("Ticketing system");
            Console.WriteLine("Ver. 0.0.0.0.0.1a");
            Console.WriteLine("\nSelect Option:\n");
            Console.WriteLine("[1] - Sell tickets");
            Console.WriteLine("[2] - Create tickets");
            Console.WriteLine("[3] - Report");
            Console.WriteLine("[4] - Exit");
            
            switch (Console.ReadLine())
            {
                case "1":
                    SellTicketsMenu();
                    return true;

                case "2":
                    CreatelTicketsMenu();
                    return true;

                case "3":
                    ReportMenu();
                    return true;

                case "4":
                    return false;

                default:
                    return true;

            }
        }

        private static bool SellTicketsMenu()
        {
            Console.WriteLine("\n Select ticket type to sell: ");
            Console.WriteLine($"[1] - 10$ ticket (ammount available: {ticketTenSellCreate})");
            Console.WriteLine($"[2] - 20$ ticket (ammount available: {ticketTwentySellCreate})");
            Console.WriteLine($"[3] - 30$ ticket (ammount available: {ticketThirtySellCreate})");
            Console.WriteLine("[4] - Back");

            switch (Console.ReadLine())
            {
                case "1":
                    TicketSell(ref ticketTenSellCreate,ref totalTenSold);
                    return true;

                case "2":
                    TicketSell(ref ticketTwentySellCreate,ref totalTwentySold);
                    return true;

                case "3":
                    TicketSell(ref ticketThirtySellCreate,ref TotalThirtySold);
                    return true;

                case "4":
                    return true;

                default:
                    return true;
            }   
        }

        private static void TicketSell(ref int ticket,ref int sold)  
        {
            Console.WriteLine("Input ammount of tickets to sell: ");
            int ammount = int.Parse(Console.ReadLine());
            ticket -= ammount;
            sold += ammount;
            Console.ReadKey();
            Console.Clear();
        }

        private static bool CreatelTicketsMenu()
        {
            Console.WriteLine("\n Select ticket type to create: ");
            Console.WriteLine($"[1] - 10$ ticket (ammount available: {ticketTenSellCreate})");
            Console.WriteLine($"[2] - 20$ ticket (ammount available: {ticketTwentySellCreate})");
            Console.WriteLine($"[3] - 30$ ticket (ammount available: {ticketThirtySellCreate})");
            Console.WriteLine("[4] - Back");

            switch (Console.ReadLine())
            {
                case "1":
                    TicketCreate(ref ticketTenSellCreate, ref totalTenCreated);
                    return true;

                case "2":
                    TicketCreate(ref ticketTwentySellCreate,ref totalTwentyCreated);
                    return true;

                case "3":
                    TicketCreate(ref ticketThirtySellCreate, ref TotalThirtyCreated);
                    return true;

                case "4":
                    return true;

                default:
                    return true;

            }
        }

        private static void TicketCreate(ref int ticket, ref int created)
        {
            Console.WriteLine("Input ammount of 10$ tickets to create: ");
            int ticketTenAmmountC = int.Parse(Console.ReadLine());
            ticket += ticketTenAmmountC;
            created += ticketTenAmmountC;
            Console.ReadKey();
            Console.Clear();
        }

        private static bool ReportMenu()
        {
            Console.WriteLine("\n Select which report to view: ");
            Console.WriteLine("[1] - total sold tickets");
            Console.WriteLine("[2] - total created tickets");
            Console.WriteLine("[3] - total unused tickets");
            Console.WriteLine("[4] - Back");

            switch (Console.ReadLine())
            {
                case "1":
                    SoldTicketsReport();
                    return true;

                case "2":
                    CreatedTicketReport();
                    return true;

                case "3":
                    UnusedTicketReport();
                    return true;

                case "4":
                    return true;

                default:
                    return true;
            }
        }  

        private static void SoldTicketsReport()
        {
            Console.WriteLine("Tickets sold ammount:\n");
            Console.WriteLine($"10$ tickets sold - {totalTenSold}");
            Console.WriteLine($"20$ tickets sold - {totalTwentySold}");
            Console.WriteLine($"30$ tickets sold - {TotalThirtySold}");
            Console.ReadKey();
            Console.Clear();
        }

        private static void CreatedTicketReport()
        {
            Console.WriteLine("Tickets created ammount:\n");
            Console.WriteLine($"10$ tickets created - {totalTenCreated}");
            Console.WriteLine($"20$ tickets created - {totalTwentyCreated}");
            Console.WriteLine($"30$ tickets created - {TotalThirtyCreated}");
            Console.ReadKey();
            Console.Clear();
        }

        private static void UnusedTicketReport()
        {
            Console.WriteLine("Tickets unused ammount: ");
            Console.WriteLine($"10$ tickets unused - {totalTenCreated - totalTenSold}");
            Console.WriteLine($"20$ tickets unused - {totalTwentyCreated - totalTwentySold}");
            Console.WriteLine($"30$ tickets unused - {TotalThirtyCreated - TotalThirtySold}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
