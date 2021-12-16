using System;
using System.Collections.Generic;
using System.Text;

namespace paskaitaDevyni
{
    public struct Bill
    {
        public int BillNr { get; set; }
        public int BillSum { get; set; }

        public Bill(int billNr, int billSum)
        {
            BillNr      =   billNr;
            BillSum     =   billSum;
        }
    }

    public struct Accounting
    {
        public List<Bill> Accounts { get; set; }

        public Accounting(List<Bill> accounts)
        {
            Accounts = accounts;


        }
    }

    //public void TotalSumOfAllBills()
    //{
        
    //}
}
