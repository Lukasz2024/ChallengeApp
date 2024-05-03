namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectSum()
        {
            //arrange
            var employee = new Employee("Adam", "Mada", "21");
            employee.AddScore(5);
            employee.AddScore(-6);
            employee.AddScore(9);

            //act
           var result = employee.Result;

            //assert
           Assert.AreEqual(8, result);
        }
    }
}