using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class DemoTest : BaseTest
    {
        private static readonly string loginUrl = url + "login";
        private const string LoginButtonLocator = "//*[contains(@class,'sign-in')]";
        private const string ErrorMessageId = "flash";

        [Test]
        public void UnsuccessfulLoginTest()
        {

        }
    }
}
