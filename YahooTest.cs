using NUnit.Framework;

namespace Test_Framework
{
    [TestFixture]
    [Parallelizable]
    public class YahooTest
    {
        [Test]
        public void testRecieveMail()
        {
            // selenium code
            System.Console.WriteLine("Testing Receiving emails");

        }

        [Test]
        public void testSendMail()
        {
            // Selenium
            System.Console.WriteLine("Testing Sending emails");
        }

        [SetUp]  // Before executing every test case
        public void openBrowser()
        {
            System.Console.WriteLine("In setUp");
        }

        [TearDown]  // After executing every test case
        public void closeBrowser()
        {
            System.Console.WriteLine("Closing Browser");
        }

    }
}