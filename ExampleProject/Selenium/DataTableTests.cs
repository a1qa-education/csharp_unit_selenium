using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class DataTableTests : BaseTest
    {
        private static readonly By sortableDataTables = By.LinkText("Sortable Data Tables");

        [Test]
        public void DataTableTest()
        {
            driver.FindElement(sortableDataTables).Click();
            //assert due sum
        }
    }
}
