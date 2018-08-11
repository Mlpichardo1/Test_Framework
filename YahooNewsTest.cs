using System;
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

            // Selenium 
            // expected value, actual value
            // test is present
            // link is present

            // Assert.AreEqual("Good", "Goods");

            System.Console.WriteLine("Before assertion error");

            try
            {
            Assert.IsTrue(4 > 22, "Error msg");
            // Assert.IsFalse(3 > 8, "Error msg");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Caught the error");
            }
            System.Console.WriteLine("After assertion error");

            // click - assertion  -try, catch block
        }

        [Test]
        public void secondTest()
        {
            Assert.Ignore("Skip the test");
        }
    }
}