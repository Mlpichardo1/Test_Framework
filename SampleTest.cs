using NUnit.Framework;

namespace Test_Framework
{
    [TestFixture]
    public class SampleTest
    {
    
        [Test]
        public void testApp()
        {
            System.Console.WriteLine("Testing App");
        }    

        [Test]
        public void testLogin()
        {
            System.Console.WriteLine("Login Test");
        }

    }
}