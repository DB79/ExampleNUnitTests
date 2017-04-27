using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleTests2.TestSuites
{
    [TestFixture]
    public class YahooTestSuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Category("Full"), Ignore("This functionality has not been added to the application"), Description("This will test that an existing user can update their details")]
        public static void AddFriends()
        {
            Assert.True(true);
        }
    }
}
