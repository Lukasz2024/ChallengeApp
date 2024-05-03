namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectSum()
        {
            //arrange
            var user = new Employee("Adam", "Mada", "21");
            user.AddScore(5);
            user.AddScore(-6);
            user.AddScore(9);

            //act
           var result = user.Result;

            //assert
           Assert.AreEqual(8, result);
        }
    }
}