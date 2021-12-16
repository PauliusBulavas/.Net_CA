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


            double firstTri    = GetTrimesterAverage(trimesterOne);
            double secondTri   = GetTrimesterAverage(trimesterTwo);
            double thirdTri    = GetTrimesterAverage(trimesterThree);
            YearlyGrade(firstTri, secondTri, thirdTri);
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
    }
}
