using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleTests.TestSuites.another_new_suite
    {
    [TestFixture]
    public class Testsuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Description("Testing addding of two numbers"),Ignore("functionality not yet complete")]
        public static void Addition()
        {
            Assert.False(false);
        }

        [Test, Category("Sanity"), Description("Testing subtraction of two numbers")]
        public static void Subtraction()
        {
            Assert.True(false);
        }

        [Test, Category("Sanity"), Description("Testing division of two numbers")]
        public static void Division()
        {
            Assert.True(false);
        }

        [Test, Category("Sanity"), Description("Testing multiplication of two numbers")]
        public static void Multiplication()
        {
            Assert.True(false);
        }
    }
}
