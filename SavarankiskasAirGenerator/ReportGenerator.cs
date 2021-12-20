using SavarankiskasAirGenerator.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{ 
    public class ReportGenerator
    {

        private AircraftModelRepository _aircraftModelRepository;
        private AircraftRepository      _aircraftRepository;
        private CompanyRepository       _companyRepository;
        private CountryRepository       _countryRepository;

        public ReportGenerator(AircraftModelRepository aircraftModelRepository,
                               AircraftRepository aircraftRepository,
                               CompanyRepository companyRepository,
                               CountryRepository countryRepository)
        {
            _aircraftModelRepository    =   aircraftModelRepository;
            _aircraftRepository         =   aircraftRepository;
            _companyRepository          =   companyRepository;
            _countryRepository          =   countryRepository;
        }

        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            List<Aircraft> aircrafts = _aircraftRepository.Retrieve();

            foreach (var aircaft in aircrafts)
            {
                Company aircraftCompany         = _companyRepository.Retrieve(aircaft.CompanyId);
                Country aircraftCountry         = _countryRepository.Retrieve(aircraftCompany.CountryId);
                AircraftModel aircraftModel     = _aircraftModelRepository.Retrieve(aircraftCountry.Id);
                if (aircraftModel == "Europe")
                {

                }

            }

        }
    }
}
