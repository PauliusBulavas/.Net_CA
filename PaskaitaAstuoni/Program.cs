using ClassLibraryOne;
using System;

namespace PaskaitaAstuoni
{
    class Program
    {
        static void Main(string[] args)
        {
            ///oop(object oriented programing) and librarys
            ///

            Book book = new Book("SUper book", "125");
            //kad nereiktu kartot book rasom var
            var book1 = new Book("Kita super book", "126");

            //int intas = 5; //naudoti int ir panasiai o ne var
            //book.TestProperty = 5; neveiktu nes nepasiekiamas kadangi private book structe book library
            int value = book.TestProperty;

        }
    }
}
