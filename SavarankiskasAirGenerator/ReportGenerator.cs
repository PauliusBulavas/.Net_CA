using SavarankiskasAirGenerator.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    public class ReportGenerator
    {
        public ReportGenerator()
        {
            _AircraftModelRepository    =   AircraftModelRepository;
            _AircraftRepository         =   AircraftRepository;
            _CompanyRepository          =   CompanyRepository;
            _CountryRepository          =   CountryRepository;


        }
    }
}
