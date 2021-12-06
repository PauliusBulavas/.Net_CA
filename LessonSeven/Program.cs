using System;

namespace LessonSeven
{
    class Program
    {
        public struct Zmogus
        {
            public string Vardas; //jei private tada tik struct veiks, kitur bus nepasiekiamas
            public string Pavarde;
            public int Amzius;

            public Zmogus(string vardas, string pavarde, int amzius) //ctor ir double tab sukuria constructor
            {
                Vardas = vardas;
                Pavarde = pavarde;
                Amzius = amzius;
            }

            public void SayName() //privaciu padarius irgi bus pasleptas, neis matyti kitur nei sitam struct
            {
                Console.WriteLine($"My name: {Vardas}");
            }
        }

        static void Main(string[] args)
        {
            Zmogus zmogus;
            zmogus.Vardas = "Jonas";
            zmogus.Pavarde = "Jonislavas";
            zmogus.Amzius = 18;
            //sitie du taspats virs ir po
            Zmogus zmogusOne = new Zmogus("Antanas", "Antanavicius", 25); //Constructor variantas


            //Zmogus zmogus1;                           //uzsetint visus kintamus reikia kitaip neveiks
            //zmogus1.Vardas = "Antanas";


            Console.WriteLine($"vardas: {zmogus.Vardas}\nPavarde: {zmogus.Pavarde}\nAmzius: {zmogus.Amzius}");
            //Console.WriteLine(zmogus1);               //Neveiks

            zmogus.SayName();
            zmogusOne.SayName();

        }
    }
}
