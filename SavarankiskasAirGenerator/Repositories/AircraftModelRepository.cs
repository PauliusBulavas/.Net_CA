using System.Collections.Generic;

namespace SavarankiskasAirGenerator.Repositories
{
    public class AircraftModelRepository
    {
        private List<AircraftModel> aircraftModels = new List<AircraftModel>();

        public AircraftModelRepository()
        {
            aircraftModels.Add(new AircraftModel(3, "B737-300", "BOEING 737-300"));
            aircraftModels.Add(new AircraftModel(4, "B737-400", "BOEING 737-400"));
            aircraftModels.Add(new AircraftModel(5, "B737-500", "BOEING 737-500"));
            aircraftModels.Add(new AircraftModel(6, "B737-700", "BOEING 737-700 "));
            aircraftModels.Add(new AircraftModel(7, "B737-800", "BOEING 737-800"));
            aircraftModels.Add(new AircraftModel(1, "A320", "AIRBUS A320"));
            aircraftModels.Add(new AircraftModel(8, "A321", "AIRBUS A321"));
            aircraftModels.Add(new AircraftModel(9, "CRJ200", "Bombardier CRJ200"));
            aircraftModels.Add(new AircraftModel(10, "ATR42-300", "ATR 42-300"));
            aircraftModels.Add(new AircraftModel(11, "ATR72-200", "ATR 72-200"));
        }

        public List<AircraftModel> Retrieve()
        {
            return aircraftModels;
        }

        public AircraftModel Retrieve(int aircraftModelId)
        {
            foreach (AircraftModel aircraftModel in aircraftModels)
            {
                if (aircraftModel.Id == aircraftModelId)
                {
                    return aircraftModel;
                }
            }
            return null;
        }
    }
}
