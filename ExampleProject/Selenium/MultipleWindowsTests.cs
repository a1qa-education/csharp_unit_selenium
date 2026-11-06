using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace ExampleProject.Selenium
{
    internal class MultipleWindowsTests : BaseTest
    {
        private static readonly By multipleWindowsLinkLoc = By.LinkText("Multiple Windows");
        private static readonly By clickHereLinkLoc = By.LinkText("Click Here");

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
