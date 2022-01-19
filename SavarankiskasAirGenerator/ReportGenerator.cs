using SavarankiskasAirGenerator.Repositories;
using System.Collections.Generic;

namespace SavarankiskasAirGenerator
{ 
    public class ReportGenerator
    {
        private AircraftModelRepository _aircraftModelRepository;
        private AircraftRepository      _aircraftRepository;
        private CompanyRepository       _companyRepository;
        private CountryRepository       _countryRepository;

        public ReportGenerator(AircraftModelRepository  aircraftModelRepository,
                               AircraftRepository       aircraftRepository,
                               CompanyRepository        companyRepository,
                               CountryRepository        countryRepository)
        {
            _aircraftModelRepository    =   aircraftModelRepository;
            _aircraftRepository         =   aircraftRepository;
            _companyRepository          =   companyRepository;
            _countryRepository          =   countryRepository;
        }

        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            List<Aircraft> aircrafts    = _aircraftRepository.Retrieve();
            List<ReportItem> report     = new List<ReportItem>();

            foreach (var aircraft in aircrafts)
            {
                var company             = _companyRepository.Retrieve(aircraft.CompanyId);
                if (company == null)
                {
                    continue;
                }
                var country             = _countryRepository.Retrieve(company.CountryId);
                var aircraftModel       = _aircraftModelRepository.Retrieve(aircraft.ModelId);

                if (country.Continent == "Europe")
                {
                    ReportItem line             = new ReportItem();
                    line.TailNumberOfAircraft   = aircraft.TailNumber;
                    line.ModelOfAircarft        = aircraftModel.Number;
                    line.ModelDescription       = aircraftModel.Description;
                    line.CompanyOfAircraft      = company.Name;
                    line.CountryCode            = country.Code;
                    line.CountryName            = country.Name;
                    line.IsPartOfEU             = country.BelongsToEu;
                    report.Add(line);
                }

                else if (country.Continent != "Europe")
                {
                    ReportItem line = new ReportItem();
                    line.TailNumberOfAircraft = aircraft.TailNumber;
                    line.ModelOfAircarft = aircraftModel.Number;
                    line.ModelDescription = aircraftModel.Description;
                    line.CompanyOfAircraft = company.Name;
                    line.CountryCode = country.Code;
                    line.CountryName = country.Name;
                    line.IsOtherContinent = country.Continent;
                    report.Add(line);
                }


            }
            return report;
        }

        public List<ReportItem> GenerateReportAircraftOtherContinents()
        {
            List<Aircraft> aircrafts = _aircraftRepository.Retrieve();
            List<ReportItem> report = new List<ReportItem>();

            foreach (var aircraft in aircrafts)
            {
                var company = _companyRepository.Retrieve(aircraft.CompanyId);
                if (company == null)
                {
                    continue;
                }
                var country = _countryRepository.Retrieve(company.CountryId);
                var aircraftModel = _aircraftModelRepository.Retrieve(aircraft.ModelId);

                if (country.Continent != "Europe")
                {
                    ReportItem line = new ReportItem();
                    line.TailNumberOfAircraft = aircraft.TailNumber;
                    line.ModelOfAircarft = aircraftModel.Number;
                    line.ModelDescription = aircraftModel.Description;
                    line.CompanyOfAircraft = company.Name;
                    line.CountryCode = country.Code;
                    line.CountryName = country.Name;
                    line.IsOtherContinent = country.Continent;
                    report.Add(line);
                }
            }
            return report;
        }

    }
}
