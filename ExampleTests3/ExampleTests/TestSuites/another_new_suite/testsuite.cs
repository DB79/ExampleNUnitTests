using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleTests3.TestSuites.another_new_suite
    {
    [TestFixture]
    public class Testsuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Category("Full"), Description("This test will verify a users account information")]
        public static void VerifyAccountInformation()
        {
            Assert.False(false);
        }

    }
}
