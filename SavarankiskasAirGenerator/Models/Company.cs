using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    public class Company
    {
        public int      Id          { get; private set; }
        public string   Name        { get; set; }
        public int?     CountryId   { get; set; }

        public Company()
        {

        }

        public Company(int id, string name, int? countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }
    }
}
