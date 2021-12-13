using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonSeven
{
    public class Program
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

        public struct Squere
        {
            public int Lenght;
            public int Width;


            public Squere(int lenght, int width)
            {
                Lenght = lenght;
                Width = width;

            }

            public int CalculateArea(int lenght, int width)
            {
                int area = width * lenght;
                Console.WriteLine($"the area of the squere is {area}");
                return area;
            }

        }

        public struct Students
        {
            public int ID;
            public bool Result;

            public Students(int id, bool result)
            {
                ID = id;
                Result = result;
            }

            public void AddStudent()
            {
                List<string> StudentList = new List<string>();
                Console.WriteLine("input the first student");
                StudentList.Add(Console.ReadLine());
                Console.WriteLine("input the second student");
                StudentList.Add(Console.ReadLine());
                Console.WriteLine("input the third student");
                StudentList.Add(Console.ReadLine());
                Console.WriteLine("input the fourth student");
                StudentList.Add(Console.ReadLine());
                Console.WriteLine("input the fifth student");
                StudentList.Add(Console.ReadLine());
            }
        }

        public struct Grades
        {
            public static double[] FirstTri = new double[] { 10, 3, 6, 8, 10 };
            public static double[] SecondTri = new double[] { 5, 2, 3, 4, 5 };
            public static double[] ThirdTri = new double[] { 8, 1, 10, 5, 8 };

            public static void Option()
            {
                double o;
                Console.WriteLine("choice of avrege for which trimester");
                Console.WriteLine("1 - trimester 2 - yearlyaverage");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(Grades.Average(FirstTri));
                        Console.WriteLine(Grades.Average(SecondTri));
                        Console.WriteLine(Grades.Average(ThirdTri));
                    break;

                    case 2:
                        Grades.YearlyAvg();
                    break;

                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
                

                
            }
            public static double Average(double[] tri)
            {
                double average = tri.Sum()/tri.Count();
                return average;
            }
            public static void YearlyAvg()
            {
                double yearly = (FirstTri.Average() + SecondTri.Average() + ThirdTri.Average()) / 3;
                Console.WriteLine($"average yearly grade is {yearly}");
                Console.ReadLine();

            }
        } 



        static void Main(string[] args)
        {
            /// task 1 ///
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

            /// task 2 ///
            /// 

            //LibraryBook book = new LibraryBook(112, "Mechanic", "Valode", new DateTime(2021, 10, 01));
            //book.BookTimeAtUser();

            /// task 3 ///
            /// 

            //Console.WriteLine("input the width and lenght of the first squere");
            //int width = Convert.ToInt32(Console.ReadLine());
            //int lenght = Convert.ToInt32(Console.ReadLine());
            //Squere squereOne = new Squere(lenght, width);
            //int areaOne = squereOne.CalculateArea(lenght, width);

            //Console.WriteLine("input the width and lenght of the second squere");
            //int width1 = Convert.ToInt32(Console.ReadLine());
            //int lenght1 = Convert.ToInt32(Console.ReadLine());
            //Squere squereTwo = new Squere(lenght1, width1);
            //int areaTwo = squereTwo.CalculateArea(lenght1, width1);

            //Console.WriteLine("input the width and lenght of the thrid squere");
            //int width2 = Convert.ToInt32(Console.ReadLine());
            //int lenght2 = Convert.ToInt32(Console.ReadLine());
            //Squere squereThree = new Squere(lenght2, width2);
            //int areaThree = squereThree.CalculateArea(lenght2, width2);

            /// task 4 ///
            /// 
            //Students students = new Students(id, result);
            //students.AddStudent();

            /// task 5///
            /// 
            Grades.Option();
            
        }
    }
}
