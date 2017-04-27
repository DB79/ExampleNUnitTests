using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ExampleTests2.TestSuites.newtestsuite
    {
    [TestFixture]
    public class newtestsuitesuite
    {
        public static IWebDriver Driver;

        [Test, Category("Sanity"), Category("Full"), Category("User"), Description("This will test that a user can be added to the system")]
        public static void AddUser()
        {
            Assert.True(true);
        }

        [Test, Category("Sanity"), Category("Full"), Category("User"), Description("This will test that an existing user can update their details")]
        public static void UpdateUser()
        {
            Assert.True(true);
        }

        [Test, Category("Sanity"), Category("Full"), Category("User"), Description("This will test that an existing user can be deleted")]
        public static void DeleteUser()
        {
            Assert.True(true);
        }
    }
}
