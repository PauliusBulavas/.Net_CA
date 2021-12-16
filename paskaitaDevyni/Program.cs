using System;
using System.Collections.Generic;

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

            ///2 --- student list trimester and yearly average
            ///

            List<int> firstTri  = new List<int> { 5, 6, 8, 3, 9 };
            List<int> secondTri = new List<int> { 10, 3, 4, 6, 5 };
            List<int> thirdTri  = new List<int> { 2, 9, 10, 2, 6 };

            var student = new Student(firstTri, secondTri, thirdTri);




            ///3 --- sukurti struct saskaita
            ///


            //List<Bill> bills = new List<Bill>
            //{
            //    new Bill { BillNr = 1, BillSum = 20 },
            //    new Bill { BillNr = 2, BillSum = 40 },
            //    new Bill { BillNr = 3, BillSum = 80 },
            //    new Bill { BillNr = 4, BillSum = 120},
            //    new Bill { BillNr = 5, BillSum = 15 },
            //    new Bill { BillNr = 6, BillSum = 23 },
            //    new Bill { BillNr = 7, BillSum = 72 },
            //    new Bill { BillNr = 8, BillSum = 12 },
            //};  


        }
    }
}
