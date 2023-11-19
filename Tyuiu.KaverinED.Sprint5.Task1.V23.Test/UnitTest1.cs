using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KaverinED.Sprint5.Task1.V23.Lib;

namespace Tyuiu.KaverinED.Sprint5.Task1.V23.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\C#\Tyuiu.KaverinED.Sprint5\Tyuiu.KaverinED.Sprint5.Task1.V23\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(false, fileExists);
        }
    }
}
