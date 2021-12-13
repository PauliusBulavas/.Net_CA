
namespace paskaitaDevyni
{
    public struct Palme
    {
        public int Amzius { get; private set; }
        public int VaisiuKiekis { get; private set; }

        // or bet neapsimoka sitaip

        //private int amziusOld;
        //private int vaisiuKiekisOld;

        //private int AmziusOld
        //{
        //    get
        //    {
        //        return amziusOld;
        //    }
        //    set
        //    {
        //        amziusOld = value;
        //    }
        //}
        //private int VaisiuKiekisOld
        //{
        //    get
        //    {
        //        return vaisiuKiekisOld;
        //    }
        //    set
        //    {
        //        vaisiuKiekisOld = value2;
        //    }
        //}


        //privalu uzsetinti construktoriu

        public Palme(int amzius, int vaisiuKiekis)
        {
            Amzius = amzius;
            VaisiuKiekis = 0;
        }

        public void PridetiVineaMenAmziaus()
        {
            Amzius++;

            TikrintiPalmesAmziu();

            SkaiciuotiPalmesVaisius();

        }

        private void SkaiciuotiPalmesVaisius()
        {
            if (Amzius >= 5)
            {
                VaisiuKiekis = Amzius * 3;
            }
        }

        private void TikrintiPalmesAmziu()
        {
            if (Amzius > 12)
            {
                VaisiuKiekis = 0;
            }
        }
    }
}
