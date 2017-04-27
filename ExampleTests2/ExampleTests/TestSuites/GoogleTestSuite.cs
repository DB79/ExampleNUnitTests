using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleTests2.TestSuites
{
    [TestFixture]
    public class GoogleTestSuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Category("Full"), Category("Account"), Description("This will test that an existing user can view their account details")]
        public static void ViewAccount()
        {
            Assert.True(false);
        }
    }
}
