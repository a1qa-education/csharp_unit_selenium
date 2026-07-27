using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace ExampleProject.Selenium
{
    internal class MultipleWindowsTests : BaseTest
    {
        private static readonly By multipleWindowsLinkLoc = By.XPath(string.Format(preciseTextXpath, "Multiple Windows"));
        private static readonly By clickHereLinkLoc = By.XPath(string.Format(preciseTextXpath, "Click Here"));

        [Test]
        public void MultipleWindowsTest()
        {
            driver.FindElement(multipleWindowsLinkLoc).Click();

            var currentWindow = driver.CurrentWindowHandle;
            driver.FindElement(clickHereLinkLoc).Click();

            // Switch to New Window and check new window text

        }
    }
}
