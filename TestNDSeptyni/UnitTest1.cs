using NUnit.Framework;
using System;
using System.Linq;
using static LessonSeven.Program;

namespace TestNDSeptyni
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double[] FirstTri = new double[] { 10, 3, 6, 8, 10 };

            var actualResult = Grades.Average(FirstTri);
            var expectedResult = FirstTri.Sum() / FirstTri.Count();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}