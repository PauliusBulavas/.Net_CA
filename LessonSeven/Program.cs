using System;

namespace LessonSeven
{
    class Program
    {
        public struct Student
        {
            public string Name;
            public string Surname;
            public int StartOf;
            public int EndOf;

            public Student(string name, string surname, int startOf, int endOf)
            {
                Name = name;
                Surname = surname;
                StartOf = startOf;
                EndOf = endOf;
            }
            public void GetData()
            {
                Console.WriteLine($"Name - {Name}, Surname - {Surname}, Start of Course - {StartOf}, End of Course - {EndOf}");
            }
        }

        public struct LibraryBook
        {
            public int ID;
            public string Name;
            public string UserName;
            public DateTime Date;

            public LibraryBook(int id, string name, string userName, DateTime date)
            {
                ID = id;
                Name = name;
                UserName = userName;
                Date = date;
            }
            public void BookTimeAtUser()
            {
                DateTime dateNow = DateTime.Today;
                Console.WriteLine($"{UserName} has the book {Name} for {dateNow - Date}");
            }

        }
        static void Main(string[] args)
        {
            /// task 1
            /// 

            //Console.WriteLine("Input your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Input your surname");
            //string surname = Console.ReadLine();
            //Console.WriteLine("Input start of course");
            //int startOf = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input end of course");
            //int endOf = Convert.ToInt32(Console.ReadLine());

            //Student student = new Student(name, surname, startOf, endOf);
            //student.GetData();

            /// task 2
            /// 
            LibraryBook book = new LibraryBook(112, "Mechanic", "Valode", new DateTime(2021, 10, 01));
            //book.Date = new DateTime(2021, 12, 06);
            book.BookTimeAtUser();
        }
    }
}
