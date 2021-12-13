using System;

namespace paskaitaDevyni
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1---- nd sukurti struct saskaita
            ///

            Saskaita.SaskaitaStruct saskaita = new Saskaita.SaskaitaStruct("Jonas", "Petras", 10);
            var saskaitaDu = new Saskaita.SaskaitaStruct("Jonas", "Petras", 10);

            ////Saskaita.SaskaitaStruct saskaitaTrys;     //neiseis nes set yra private
            ////saskaitaTrys.Gavejas = "Jhon";
            ////sitaip overwritina virsuje esancia saskaitaDu
            ////saskaitaDu = new Saskaita.SaskaitaStruct("Ona", "Domicele", 100);

            ///2 --- sukurti struct palme
            ///

            var palme = new Palme(5, 5);
            palme.PridetiVineaMenAmziaus();

            ///3 --- sukurti struct miskas
            ///

            var miskas = new Miskas();
            miskas.PasodintiMedi();

        }
    }
}
