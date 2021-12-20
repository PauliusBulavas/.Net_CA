using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    public class HTMLGenerator
    {
        public void GenerateHTMLWithColor(List<ReportItem> report)
        {
            report.ForEach(Console.WriteLine);
        }
    }
}
