using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace paskaitaDevyni
{
    public struct Student
    {
        public List<int> TrimesterOneGrades { get;  set; }
        public List<int> TrimesterTwoGrades { get;  set; }
        public List<int> TrimesterThreeGrades { get;  set; }

        public Student(List<int> trimesterOne, List<int> trimesterTwo, List<int> trimesterThree)
        {
            TrimesterOneGrades      =       trimesterOne;   
            TrimesterTwoGrades      =       trimesterTwo;   
            TrimesterThreeGrades    =       trimesterThree;


            double firstTriAvg    =     GetTrimesterAverage(trimesterOne);
            double secondTriAvg   =     GetTrimesterAverage(trimesterTwo);
            double thirdTriAvg    =     GetTrimesterAverage(trimesterThree);
            YearlyGrade(firstTriAvg, secondTriAvg, thirdTriAvg);
        }

        public double GetTrimesterAverage(List<int> trimester)
        {
            double average = trimester.Average();
            Console.WriteLine(average);
            return average;
        }

        public double YearlyGrade(double first, double second, double third)
        {
            double yearlyAverage = (first + second + third) / 3;
            Console.WriteLine($"Yearly average of the three trimesters is : {yearlyAverage}");
            return yearlyAverage;
        }

        public static void Options()
        {
            Console.WriteLine("What do you want to do?");

            Console.WriteLine("[1] - select the trimester of which to view the avrages or edit");
            Console.WriteLine("[2] - see the yearly average");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TrimesterSelect();
                    break;

                case 2:
                    YearlyGrade(firstTriAvg, secondTriAvg, thirdTriAvg);
                    break;

                default:
                    Console.WriteLine("wrong input");
                    break;
            }

        }

        public static void FuncitionToRun(List<int> trimester)
        {
            Console.WriteLine("which trimester do you want to view/edit ?");
            Console.WriteLine("[1] - First trimester");
            Console.WriteLine("[2] - Second trimester");
            Console.WriteLine("[3] - Third trimester");
        }
        public static void TrimesterSelect()
        {
            Console.WriteLine("which trimester do you want to view/edit ?");
            Console.WriteLine("[1] - First trimester");
            Console.WriteLine("[2] - Second trimester");
            Console.WriteLine("[3] - Third trimester");


            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddGradesTri(trimesterOne);
                case 2:
                    AddGradesTri(trimesterTwo);
                case 3:
                    AddGradesTri(trimesterThree);
                default:
                    break;
            }
        }

        public static void AddGradesTri(List<int> trimester)
        {
            int index = 0;

            Console.WriteLine("Current grades: ");
            foreach (var grade in trimester)
            {
                Console.WriteLine($"{index} - {grade}");
                index++;
            }
            Console.WriteLine("What grade to add? ");
            trimester.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("updated grades: ");
            foreach (var grade in trimester)
            {
                Console.WriteLine($"{index} - {grade}");
                index++;
            }
        }

        public static void RemoveGradesTri(List<int> trimester)
        {
            int index = 0;
            Console.WriteLine("Current grades: ");
            foreach (var grade in trimester)
            {
                Console.WriteLine($"{index} - {grade}");
                index++;
            }
            Console.WriteLine("Which grade to delete?");
            trimester.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("updated grades: ");
            foreach (var grade in trimester)
            {
                Console.WriteLine($"{index} - {grade}");
                index++;
            }
        }

        public static void InsertGradesTri(List<int> trimester)
        {
            int index = 0;
            Console.WriteLine("Current grades: ");
            foreach (var grade in trimester)
            {
                Console.WriteLine($"{index} - {grade}");
                index++;
            }
            Console.WriteLine("Where to insert?");
            trimester.Insert(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("updated grades: ");
            foreach (var grade in trimester)
            {
                Console.WriteLine($"{index} - {grade}");
                index++;
            }
        }



    }
}
