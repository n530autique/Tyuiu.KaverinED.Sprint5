using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.KaverinED.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\egorkaverin\source\repos\Tyuiu.KaverinED.Sprint5\Tyuiu.KaverinED.Sprint5.Task7.V1\bin\Debug\OutPutDataFileTask7V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
