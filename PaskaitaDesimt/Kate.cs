using System;
using System.Collections.Generic;
using System.Text;

namespace PaskaitaDesimt
{
    public class Kate : Zinduolis //paveldime is zinduolis ir igauna zinduolio funkcionalumus
    {
        public string KailioSpalva { get; set; }

        public void Miaukti()
        {
            Console.WriteLine("Miau");
        }
    }
}
