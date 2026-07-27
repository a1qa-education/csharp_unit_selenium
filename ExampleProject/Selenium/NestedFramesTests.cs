using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace ExampleProject.Selenium
{
    internal class NestedFramesTests : BaseTest
    {
        private static readonly By framesBtn = By.XPath(string.Format(preciseTextXpath, "Frames"));
        private static readonly By nestedFramesBtn = By.XPath(string.Format(preciseTextXpath, "Nested Frames"));

        [Test]
        public void NestedFramesTest()
        {
            driver.FindElement(framesBtn).Click();
            driver.FindElement(nestedFramesBtn).Click();
            
            // Switch to Left Frame
            
            // Check Left frame text

            // Switch to Right Frame

            // Check Left frame text

        }
    }
}