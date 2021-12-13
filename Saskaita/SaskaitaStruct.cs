using System;

namespace Saskaita
{
    public struct SaskaitaStruct
    {
        public string Gavejas { get; private set; }
        public string Siuntejas { get; private set; }
        public decimal MoketiViso { get; private set; }
        public string SaskaitosNr { get; private set; }

        public SaskaitaStruct(string gavejas, string siuntejas, decimal moketiViso)
        {
            Gavejas = gavejas;
            Siuntejas = siuntejas;
            MoketiViso = moketiViso;
            SaskaitosNr = string.Empty;
            SukurtiSaskaitosNr();
        }

        private void SukurtiSaskaitosNr()
        {
            SaskaitosNr = string.Format($"NR_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_01");
        }

    }
}
