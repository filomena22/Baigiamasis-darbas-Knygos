using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://www.knygos.lt/");
            Home.CloseCookies();
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
