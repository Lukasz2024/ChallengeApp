namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            //arrange
            string number1 = "Adam";
            string number2 = "Adam";

            //act


            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetUser("Adam");
            var employee2 = GetUser("Monika");

            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee GetUser(string Name) => new Employee(Name);
    }
}
