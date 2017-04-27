using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleTests2.TestSuites.another_new_suite
    {
    [TestFixture]
    public class Testsuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Category("Full"), Description("This test will login to the application")]
        public static void LoginTest()
        {
            Assert.False(false);
        }

        [Test, Category("Sanity"), Category("Full"), Description("This test will test the logout functionality")]
        public static void LogoutTest()
        {
            Assert.True(false);
        }
    }
}
