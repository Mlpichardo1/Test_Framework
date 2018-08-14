using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test_Framework
{
    [TestFixture]
    public class DynamicTest
    {
        [Test]
        static void Main(string[] args) // Initialize
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\User\");
            driver.Navigate().GoToUrl("https://www.americangolf.co.uk/golf-clubs/drivers");
            //*[@id="secondary"]/div[1]/div[2]/div/ul/li[1]/a/span[2]
            //*[@id="secondary"]/div[1]/div[2]/div/ul/li[2]/a/span[2]

            IList<IWebElement> brandNumbers = driver.FindElements(By.XPath("//*[@id='secondary']/div[1]/div[2]/div/ul/li/a/span[2]"));
            System.Console.WriteLine("Total brandNumbers: " + brandNumbers.Count);
            
            int sum = 0;
            for(int i = 0; i < brandNumbers.Count; i++)
            {
                Console.WriteLine(brandNumbers[i].Text);
                string text = brandNumbers[i].Text;
                string t = null;

                    if(text.Length == 4)
                        t = text.Substring(1, 2);

                    else if (text.Length == 3)
                        t = text.Substring(1, 1);

                    int x = Convert.ToInt32(t); 

                    sum = sum + x;  

                // Console.WriteLine(t);
            }

            System.Console.ReadKey();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass("Your first passing test");
        }
    }
}