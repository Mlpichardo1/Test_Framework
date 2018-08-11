using NUnit.Framework;

namespace Test_Framework
{
    [TestFixture]
    [Parallelizable]
    //[Ignore("Skip the Test")]
    public class YahooNewsTest
    {
        [Test]
        public void testNews()
        {
            System.Console.WriteLine("Test News");
        }

        [Test]
        public void secondTest()
        {
            Assert.Ignore("Skip the test");
        }
    }
}