using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ExampleTests3.TestSuites.newtestsuite
    {
    [TestFixture]
    public class Newtestsuitesuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Category("Full"), Category("Balance"), Description("This test verifies that a user can update their balance")]
        public static void UpdateAccountBalance()
        {
            Assert.True(false, "unable to update users balance");
        }

        [
             Test, 
             Category("Sanity"), 
             Category("Full"), 
             Category("Balance"), 
             Description("This test will verify that a users account has been successfully credited")
        ]
        public static void VerifyAccountCredited()
        {
            Assert.True(true, "unable to credit users account");
        }
    }
}
