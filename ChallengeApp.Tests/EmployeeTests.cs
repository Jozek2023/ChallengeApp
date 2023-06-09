//namespace ChallengeApp.Tests
//{
//    public class EmployeeTests
//    {
//        [Test]
//        public void GetStatisticsShouldReturnCorrectAverageAsLetter()
//        {
//            // arrange - przygotowanie
//            var employee = new EmployeeBase("Piotr", "zgubiony");
//            employee.AddGrade(90);
//            employee.AddGrade('b');
//            employee.AddGrade('c');

//            // act - uruchomienie
//            var statistics = employee.GetStatistics();

//            // assert - sprawdzenie warunków
//            Assert.AreEqual('B', statistics.AverageLetter);
//        }

//        [Test]
//        public void GetStatisticsShouldReturnCorrectMinAndMaxValue()
//        {
//            // arrange - przygotowanie
//            var employee = new EmployeeBase("Piotr", "zgubiony");
//            employee.AddGrade(101);
//            employee.AddGrade('e');
//            employee.AddGrade(99);
//            employee.AddGrade('A');
//            employee.AddGrade(21);

//            // act - uruchomienie
//            var statistics = employee.GetStatistics();

//            // assert - sprawdzenie warunków
//            Assert.That(statistics.Min, Is.EqualTo(20));
//            Assert.That(statistics.Max, Is.EqualTo(100));
//        }

//        [Test]
//        public void GetStatisticsShouldReturnCorrectOutputUsingString()
//        {
//            // arrange - przygotowanie
//            var employee = new EmployeeBase("Piotr", "zgubiony");
//            employee.AddGrade("500");
//            employee.AddGrade("KKK");
//            employee.AddGrade("50");
//            employee.AddGrade("51");

//            // act - uruchomienie
//            var statistics = employee.GetStatistics();

//            // assert - sprawdzenie warunków
//            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
//        }

//        [Test]
//        public void AddCharGradeShouldBeEqualToCorrectValue()
//        {
//            // arrange - przygotowanie
//            var employee = new EmployeeBase("Piotr", "zgubiony");
//            employee.AddGrade('a');

//            // act - uruchomienie
//            var statistics = employee.GetStatistics();

//            // assert - sprawdzenie warunków
//            Assert.That(statistics.Max, Is.EqualTo(100));
//        }
//    }
//}