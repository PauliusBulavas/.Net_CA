using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    public class Country
    {
        public int Id { get; private set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool BelongsToEu { get; set; }

        public Country()
        {

        }

        public Country(int id, string code, string name, string continent, bool belongsToEu)
        {
            Id = id;
            Code = code;
            Name = name;
            Continent = continent;
            BelongsToEu = belongsToEu;
        }
    }
}

