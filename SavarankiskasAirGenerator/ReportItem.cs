using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    public class ReportItem
    {
        public string   TailNumberOfAircraft    { get; set; }
        public string   ModelOfAircarft         { get; set; }
        public string   CompanyOfAircraft       { get; set; }
        public string   CountryCode             { get; set; }
        public string   CountryName             { get; set; }
        public string   ModelDescription        { get; set; }
        public bool?    IsPartOfEU              { get; set; }
    }
}
