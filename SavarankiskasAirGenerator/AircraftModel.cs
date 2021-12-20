using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    public class AircraftModel
    {
        public int Id { get; private set; }
        public string Number { get; set; }
        public string Description { get; set; }

        public AircraftModel()
        {

        }

        public AircraftModel(int id, string number, string description)
        {
            Id              = id;
            Number          = number;
            Description     = description;
        }
    }
}
