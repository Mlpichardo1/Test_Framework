using NUnit.Framework;

namespace Test_Framework
{
    [TestFixture]
    [Ignore("skip this test")]
    public class YahooRegistrationTest
    {
        [Test, TestCaseSource("registerData")]
        public void testRegister(string username, string password, string email, string city)
        {
            // selenium
            // username
            // password
            // email
            // city

            System.Console.WriteLine(username + " -- " + password + " -- " + email + " -- " + city);

        }

        // data source
        public static object[] registerData()
        {
            // Rows = no. of times it has to be executed
            // Cols = no. of parameters in data
            object[][] data = new object[3][];

            // First Row
            data[0] = new object[4];
            data[0][0] = "user1";
            data[0][1] = "pass1";
            data[0][2] = "email1";
            data[0][3] = "city1";

            // Second Row
            data[0] = new object[4];
            data[0][0] = "user2";
            data[0][1] = "pass2";
            data[0][2] = "email2";
            data[0][3] = "city2";

            // Third Row
            data[0] = new object[4];
            data[0][0] = "user3";
            data[0][1] = "pass3";
            data[0][2] = "email3";
            data[0][3] = "city3";

            return data;
        }
    }
}