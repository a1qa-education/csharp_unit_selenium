using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class FileDownloadTests : BaseTest
    {
        //Make sure that the name of the file is present on the page before running the test
        private static readonly string fileName = "test.txt";

        private static readonly By fileDownloadBtn = By.XPath(string.Format(preciseTextXpath, "File Download"));
        private static readonly By fileNameField = By.XPath(string.Format(preciseTextXpath, fileName));

        private static readonly string filePath = Path.Combine(relativePathFolder, fileName);
        private static readonly FileInfo downloadedFile = new(Path.GetFullPath(filePath));

        [Test]
        public void FileDownloadTest()
        {
            driver.FindElement(fileDownloadBtn).Click();
            Assert.True(driver.FindElement(fileNameField).Displayed, "File is not displayed");
            driver.FindElement(fileNameField).Click();
            //assert the file is downloaded
        }

        //delete the downloaded file
    }
}
