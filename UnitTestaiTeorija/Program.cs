using System;

namespace UnitTestaiTeorija
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static decimal SkaiciuotiMokescius(decimal pajamos)
        {
            decimal rezultatas = 0;

            if (pajamos <= 400)
            {
                rezultatas = pajamos * 0.05m;
            }
            else if(pajamos > 400 && pajamos <= 1000)
            {
                rezultatas = pajamos * 0.15m;
            }
            else
            {
                rezultatas = pajamos * 0.25m;
            }

            return rezultatas;
        }
    }
}
