
using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class TypeTests
    { 


        [Test]
        public void ThisTwoIntObject()
        {
            //arrange
            int number1 = 7;
            int number2 = 7;

            //act
            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]

        public void ThisTwoFloatObject()
        {
            // arrange
            float number3 = 8999999999;
            float number4 = 8999999999;

            //act
            //assert
            Assert.AreEqual(number3, number4);
        }

        [Test]

        public void ThisTwoStringObject()
        {
            // arrange
            string name1 = "Jan";
            string name2 = "Jan";

            //act
            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]

        public void GetEmployeeShouldReturnDifferentObject()
        {
            // arrange
            Employee employee1 = GetEmployee("Jan", "Trzeci", 23);
            Employee employee2 = GetEmployee("Jan", "Trzeci", 23);

            //act
            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        { 
            return new Employee(name,surname, age);

        }
    }
}
