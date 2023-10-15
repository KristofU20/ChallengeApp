

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectThreeSetOfPoint_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Jan", "Mazoch", 45);
            employee.AddScore(9);
            employee.AddScore(2);
            employee.AddScore(-11);
            // act
            var result = employee.Result;


            // assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void WhenUserCollectFoureSetOfPoint_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Franek", "Smith", 19);
            employee.AddScore(9);
            employee.AddScore(2);
            employee.AddScore(-11);
            employee.AddScore(-12);
            // act
            var result = employee.Result;


            // assert
            Assert.AreEqual(-12, result);
        }
    } 

        
}