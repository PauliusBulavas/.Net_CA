using NUnit.Framework;
using UnitTestaiTeorija;

namespace TestProjectOne
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SkaiciuotiMokesciusSu350Pajamu()
        {
            //Arrange (kuriam data)
            decimal pajamos = 350m;
            decimal expectedResult = 17.5m;

            //Act (callinam metoda)
            var actualResult = Program.SkaiciuotiMokescius(pajamos);

            //Assert (lyginam output expecter su actual)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}