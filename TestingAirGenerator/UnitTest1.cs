using NUnit.Framework;
using SavarankiskasAirGenerator;
using SavarankiskasAirGenerator.Repositories;

namespace TestingAirGenerator
{
    public class Tests
    {
        [Test]
        public void GenerateReportAircraftInEurope()
        {
            var aircraftModelRepository = new AircraftModelRepository();

            string ModelDescription = "BOEING 737-800";

            var actualResult = aircraftModelRepository.Retrieve(7);

            Assert.AreEqual(ModelDescription, actualResult.Description);
        }


    }
}