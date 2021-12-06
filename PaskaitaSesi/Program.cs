using System;
using System.Linq;

namespace PaskaitaSesi
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////method overload
            //nupiestiRemeli(10);


            ////////////////////value vs ref
            //int skaicius = 10;
            //Console.WriteLine($"pries: {skaicius}");
            //keiciameArgumentus(skaicius);
            //keiciameArgumentusPagalRef(ref skaicius);
            //Console.WriteLine($"po: {skaicius}");

            //int sum = calculateSumRecursivley(1, 3);
            //int sum2 = calculateSumRecursivley(2, 3);
            //int sum3 = calculateSumRecursivley(3, 3);

            Vardas();

            VardasNKartu(5);

            SimboliuKiekis("lauke sninga");

            KMI(68, 1.79);

            TarpuKiekis("sakinys su trim tarpais");

            int[] skaiciai = { 2, 5, 9, 7, 5, 3 };
            SkaiciuSumaKiekis(skaiciai);

            PakeltiLaipsniu(2, 3);

            PerkrautosFunkcijos(1, 10);

            FibonacciSeka(20);

            AtskiruSkaiciausSkaitmenuSuma(1235);

            FaktorialoSkaiciavimas(5);
        }

        #region Method overload
        //private, public, static
        // static gali eit su public ir private
        //
        //public is betkur pasiekiams, private ne, static tik karta sukuriamas, geresnis performance
        // static naudodi visada rekomended


        private static void nupiestiRemeli(int remelioIlgis)
        {
            int whatSizeSquere = remelioIlgis;
            string squereSymbol = "*";
            string spaceSymbol = " ";

            //virsutine eilute
            for (int i = 0; i < whatSizeSquere; i++)
            {
                Console.Write(squereSymbol);
            }

            Console.WriteLine();

            //vidurine eilute
            Console.Write("{0} {1} {2}", squereSymbol, spaceSymbol, whatSizeSquere);
            int lenghtOfNumber = whatSizeSquere.ToString().Length;
            int kiekTarpuPraleist = squereSymbol.Length * 2 + lenghtOfNumber + spaceSymbol.Length;

            for (int kiekTarpuPraleisti = 0; kiekTarpuPraleisti < whatSizeSquere; kiekTarpuPraleisti++)
            {
                Console.Write(spaceSymbol);
            }
            Console.Write(squereSymbol);

            Console.WriteLine();

            //apatine eilute

            for (int i = 0; i < whatSizeSquere; i++)
            {
                Console.Write(squereSymbol);
            }
            Console.WriteLine();
        }

        private static void nupiestiRemeli(int remelioIlgis, int remelioplotis)
        {
            int whatSizeSquere = remelioIlgis;
            int whatSizeSquere2 = remelioplotis;
            string squereSymbol = "*";
            string spaceSymbol = " ";

            //virsutine eilute
            for (int i = 0; i < whatSizeSquere; i++)
            {
                Console.Write(squereSymbol);
            }

            Console.WriteLine();

            //vidurine eilute
            Console.Write("{0} {1} {2}", squereSymbol, spaceSymbol, whatSizeSquere);
            int lenghtOfNumber = whatSizeSquere.ToString().Length;
            int kiekTarpuPraleist = squereSymbol.Length * 2 + lenghtOfNumber + spaceSymbol.Length;

            for (int kiekTarpuPraleisti = 0; kiekTarpuPraleisti < whatSizeSquere; kiekTarpuPraleisti++)
            {
                Console.Write(spaceSymbol);
            }
            Console.Write(squereSymbol);

            Console.WriteLine();

            //apatine eilute

            for (int i = 0; i < whatSizeSquere; i++)
            {
                Console.Write(squereSymbol);
            }
            Console.WriteLine();
        }

        public static void nupiestiRemeli1(int remelioIlgis, int remelioplotis)
        {
            int whatSizeSquere = remelioIlgis;
            int whatSizeSquere2 = remelioplotis;
            string squereSymbol = "*";
            string spaceSymbol = " ";

            //virsutine eilute
            for (int i = 0; i < whatSizeSquere; i++)
            {
                Console.Write(squereSymbol);
            }

            Console.WriteLine();

            //vidurine eilute
            Console.Write("{0} {1} {2}", squereSymbol, spaceSymbol, whatSizeSquere);
            int lenghtOfNumber = whatSizeSquere.ToString().Length;
            int kiekTarpuPraleist = squereSymbol.Length * 2 + lenghtOfNumber + spaceSymbol.Length;

            for (int kiekTarpuPraleisti = 0; kiekTarpuPraleisti < whatSizeSquere; kiekTarpuPraleisti++)
            {
                Console.Write(spaceSymbol);
            }
            Console.Write(squereSymbol);

            Console.WriteLine();

            //apatine eilute

            for (int i = 0; i < whatSizeSquere; i++)
            {
                Console.Write(squereSymbol);
            }
            Console.WriteLine();
        }
        #endregion

        #region ref vs value

        //int skaicius = 10;
        //Console.WriteLine($"pries: {skaicius}");
        //keiciameArgumentus(skaicius);
        //keiciameArgumentusPagalRef(ref skaicius);
        //Console.WriteLine($"po: {skaicius}");

        private static void keiciameArgumentus(int skaicius) //sukuriam <skaicius> kopija, tampa lokalis, po metodo jis dingsta
        {
            skaicius = skaicius + 10;
            Console.WriteLine($"pakeistas skaicius: {skaicius}");
        }

        private static void keiciameArgumentusPagalRef(ref int skaicius) //paduodam zyma (skaicius is 9 eilutes) ir jis modifikuoja ji
        {
            skaicius = skaicius + 10;
            Console.WriteLine($"pakeistas skaicius: {skaicius}");
        }
        #endregion

        #region recursivley
        private static int calculateSumRecursivley(int n, int m) //recursivly reiskia kad method savy naudoja save
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += calculateSumRecursivley(n, m);
            }

            return sum;

        }
        #endregion

        //1

        private static void Vardas()
        {
            Console.WriteLine("Paulius");
        }

        private static void VardasNKartu(int vardasNKartu)
        {
            string vardas = "Paulius";

            for (int i = 0; i < vardasNKartu; i++)
            {
                Console.WriteLine(vardas);
            }

        }

        private static void SimboliuKiekis(string simboliuKiekis)
        {
            string simbolis = "#";

            int kiekis = simboliuKiekis.Length;

            for (int i = 0; i < kiekis; i++)
            {
                Console.Write(simbolis);
            }

            Console.WriteLine(" ");
        }

        private static void KMI(double mase, double ugis)
        {
            double kvadratu = Math.Pow(ugis, 2);
            double kmi = mase / kvadratu;

            Console.WriteLine($"KMI yra {kmi}");
        }

        //2
        private static void TarpuKiekis(string tarpuKiekis)
        {
            int count = tarpuKiekis.Count(f => f == ' ');
            Console.WriteLine($"sakiny yra {count} tarpai");
        }

        private static void SkaiciuSumaKiekis(int[] args)
        {
            int sum = args.Sum();
            Console.WriteLine($"suma - {sum}");
            int totalElements = args.Count();
            Console.WriteLine($"skaiciu kiekis - {totalElements}");
        }

        private static void PakeltiLaipsniu(double skaicius, double laipsnis)
        {
            double kvadratu = Math.Pow(skaicius, laipsnis);

            Console.WriteLine($"{skaicius} ^ {laipsnis} = {kvadratu}");
        }

        private static void PerkrautosFunkcijos(int n, int m)
        {
            int totalSum = 0;
            while (n <= m)
            {
                totalSum += n;
                n++;
            }

            Console.WriteLine($"suma nuo {n} iki {m} yra - {totalSum}");
        }

        private static void PerkrautosFunkcijos(int n, int m, bool rodytiTarpineSuma) //nesuprantu uzduoties
        {
            int totalSum = 0;
            while (n <= m)
            {
                totalSum += n;
                n++;
                Console.WriteLine($"{n} ");
            }

            Console.WriteLine($"suma yra - {totalSum}");
        }

        //advanced

        //1//nesuprantu uzduoties

        //2 fabionaci seka
        
        private static void FibonacciSeka (int lenght)
        {
            int a = 0, b = 1, c = 0;

            for (int i = 2; i < lenght; i++)
            {
                c = a + b;
                Console.Write($"{c}, ");
                a = b;
                b = c;
            }
        }

        //3 atskiru betkurio skaiciaus skaitmenu suma

        private static void AtskiruSkaiciausSkaitmenuSuma(int skaicius)
        {
            Console.WriteLine("iveskite skaiciu kurio skaitmenis sudeti: ");
            int sum = 0;
            while (skaicius != 0)
            {
                sum += skaicius % 10;
                skaicius /= 10;
            }
            Console.WriteLine($"skaiciaus  skaitmenu suma yra: {sum}");
        }

        //4 faktorialine daugyba

        private static void FaktorialoSkaiciavimas(int faktorialas)
        {
            int fact = 1;
            for (int i = 1; i <= faktorialas; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"faktorialas !{faktorialas} yra {fact}");
        }
        
    }
}
