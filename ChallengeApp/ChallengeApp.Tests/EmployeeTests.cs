

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestsMin()
        {
            //arrange
            var employee = new Employee("Jan", "Mazoch");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);
            // act
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(2, statistics.Min);
        }


        [Test]
        public void TestsMax()
        {
            //arrange
            var employee = new Employee("Jan", "Mazoch");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);
            // act
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(6, statistics.Max);

        }


        [Test]
        public void TestsAverage()
        {
            //arrange
            var employee = new Employee("Jan", "Mazoch");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);
            // act
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(4, statistics.Average);

        }
    }
}