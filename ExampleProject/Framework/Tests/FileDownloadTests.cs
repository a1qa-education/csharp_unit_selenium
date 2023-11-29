﻿using ExampleProject.Framework.Pages;
using NUnit.Framework;
using System.IO;

namespace ExampleProject.Framework.Tests
{
    internal class FileDownloadTests : BaseTest
    {
        private FileDownloadPage fileDownloadPage = new();
        private static readonly string fileName = testdata.GetValue<string>("fileDownload.folderPath");
        private static readonly string filePath = testdata.GetValue<string>("fileDownload.fileName") + fileName;
        private static readonly FileInfo downloadedFile = new(Path.GetFullPath(filePath));

        [Test]
        public void FileDownloadTest()
        {
            //todo: implement a test
        }

        [TearDown]
        public void DeleteFile()
        {
            //todo: delete a file
        }
    }
}
