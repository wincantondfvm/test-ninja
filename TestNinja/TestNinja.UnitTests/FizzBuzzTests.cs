using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetOutput_NumberDivisibleByThree_ReturnsFizz()
        {
            string result = FizzBuzz.GetOutput(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NumberDivisibleByFive_ReturnsBuzz()
        {
            string result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberDivisibleByThreeAndFive_ReturnsFizzBuzz()
        {
            string result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NumberNotDivisibleByThreeOrFive_ReturnsSameNumber()
        {
            string result = FizzBuzz.GetOutput(7);

            Assert.That(result, Is.EqualTo("7"));
        }
    }
}
