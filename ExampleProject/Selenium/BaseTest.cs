using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ExampleProject
{
    internal abstract class BaseTest
    {
        protected IWebDriver driver = null!;
        protected WebDriverWait wait = null!;

        protected static readonly string url = "https://the-internet.herokuapp.com/";
        protected static readonly string relativePathFolder = "Resources";
        protected static readonly int maxWait = 10;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWait));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Dispose();
        }
    }
}
