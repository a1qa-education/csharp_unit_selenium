using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class BasicAuthTest : BaseTest
    {
        INetwork? networkInterceptor = null;
        private static readonly By basicAuth = By.XPath(string.Format(preciseTextXpath, "Basic Auth"));
        private static readonly By successAuth = By.XPath(string.Format(partialTextXpath, "Congratulations! You must have the proper credentials"));

        [SetUp]
        public void Authorize()
        {
            NetworkAuthenticationHandler handler = new NetworkAuthenticationHandler()
            {
                //add credentials
            };

            networkInterceptor = driver.Manage().Network;
            networkInterceptor.AddAuthenticationHandler(handler);
            networkInterceptor.StartMonitoring();
        }

        [Test]
        public void SuccessfulBasicAuthTest()
        {
            driver.FindElement(basicAuth).Click();
            Assert.That(driver.FindElement(successAuth).Displayed, Is.True, "Message is not displayed");
        }

        //stop monitoring after test
    }
}