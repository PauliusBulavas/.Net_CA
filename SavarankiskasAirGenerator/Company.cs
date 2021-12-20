using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    class Company
    {
        public Company()
        {

        }

        public Company(int id, string name, string countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
    }
}
