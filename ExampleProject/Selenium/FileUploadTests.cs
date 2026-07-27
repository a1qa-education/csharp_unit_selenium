using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Selenium
{
    internal class FileUploadTests : BaseTest
    {
        private static readonly By fileUploadBtn = By.XPath(string.Format(preciseTextXpath, "File Upload"));
        private static readonly string fileName = "ExampleFile.txt";
        private static readonly string filePath = Path.Combine(relativePathFolder, fileName);

        [Test]
        public void FileUploadTest()
        {
            driver.FindElement(fileUploadBtn).Click();
            FileInfo fileToUpload = new(Path.GetFullPath(filePath));
            //upload a new file
            //assert file is uploaded
        }
    }
}
