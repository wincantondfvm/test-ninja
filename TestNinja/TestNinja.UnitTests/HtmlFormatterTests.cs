using NUnit.Framework;
using System.Runtime.Serialization;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    public class HtmlFormatterTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElement()
        {
            HtmlFormatter formatter = new HtmlFormatter();

            string result = formatter.FormatAsBold("hello world");

            Assert.That(result, Is.EqualTo("<strong>hello world</strong>").IgnoreCase);
        }
    }
}
