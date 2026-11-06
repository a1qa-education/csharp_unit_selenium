using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class DynamicControlsTests : BaseTest
    {
        private static readonly By dynamicControl = By.LinkText("Dynamic Controls");
        private static readonly By enableBtn = By.XPath("//button[normalize-space(text())='Enable']");

        [Test]
        public void DynamicControlsTest()
        {
            driver.FindElement(dynamicControl).Click();
            driver.FindElement(enableBtn).Click();

            //assert input is enabled
            //input randomly generated text
            //assert input text
        }
    }
}
