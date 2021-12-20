using System;
using System.Collections.Generic;
using System.Text;

namespace SavarankiskasAirGenerator
{
    class Aircraft
    {
        public Aircraft()
        {

        }

        public Aircraft(int id, string modelId, string companyId, string tailNumber)
        {
            Id = id;
            ModelId = modelId;
            CompanyId = companyId;
            TailNumber = tailNumber;
        }
        public int Id { get; private set; }
        public string ModelId { get; set; }
        public string CompanyId { get; set; }
        public string TailNumber { get; set; }
    }
}
}
