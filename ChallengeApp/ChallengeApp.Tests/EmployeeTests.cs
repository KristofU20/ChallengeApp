

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestsMin()
        {
            //arrange
            var employee = new Employee("Jan", "Mazoch");
            employee.AddGrade(4);
            employee.AddGrade('d');
            employee.AddGrade('e');
            // act
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(4, statistics.Min);
        }


        [Test]
        public void TestsMax()
        {
            //arrange
            var employee = new Employee("Jan", "Mazoch");
            employee.AddGrade(25);
            employee.AddGrade('C');
            employee.AddGrade("D");
            // act
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(60, statistics.Max);

        }


        [Test]
        public void TestsAverage()
        {
            //arrange
            var employee = new Employee("Jan", "Mazoch");
            employee.AddGrade(20);
            employee.AddGrade('a');
            employee.AddGrade('C');
            // act
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(60, statistics.Average);

        }
    }
}