using challengeApp_;

namespace challengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldCorectsResult()
        {
            // arrange
            var employee1 = new Employee("Marcin", "Nowak", 33);
            employee1.AddScore(2);
            employee1.AddScore(4);
            employee1.AddScore(6);
            employee1.AddScore(8);
            employee1.AddScore(10);

            // act
            var result = employee1.Result;

            // assert
            Assert.AreEqual(30, result);
        }


    }
}