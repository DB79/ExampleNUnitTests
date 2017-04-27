using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleTests3.TestSuites
{   
    [TestFixture]
    public class GoogleTestSuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Category("Full"), Category("Transaction"), Description("This test will verify that a transactions has completed successfully")]
        public static void VerifyTransactions()
        {
            Assert.True(false, "an error occurred will trying to complete the transaction");
        }

        [Test, Category("Sanity"), Category("Full"), Category("Transaction"), Description("This test will verify that the correct error messsage is displayed")]
        public static void VerifyFailureMessage()
        {
            Assert.True(true);
        }
    }
}
