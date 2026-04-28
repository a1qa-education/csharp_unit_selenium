using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class DynamicControlsTests : BaseTest
    {
        private static readonly By dynamicControl = By.XPath(string.Format(preciseTextXpath, "Dynamic Controls"));
        private static readonly By enableBtn = By.XPath(string.Format(preciseTextXpath, "Enable"));
        private static readonly By inputField = By.XPath("//*[@id='input-example']//input");
        private static readonly string randomText = Guid.NewGuid().ToString();

        [Test]
        public void DynamicControlsTest()
        {
            driver.FindElement(dynamicControl).Click();
            driver.FindElement(enableBtn).Click();

            var inputElement = wait.Until(d =>
            {
                var el = d.FindElement(inputField);
                return (el.Enabled && el.Displayed) ? el : null;
            });

            Assert.That(inputElement, Is.Not.Null, "Input field was not enabled in time.");

            inputElement.SendKeys(randomText);

            Assert.That(inputElement.GetAttribute("value"), Is.EqualTo(randomText), "The input value does not match the generated GUID.");
        }
    }
}
