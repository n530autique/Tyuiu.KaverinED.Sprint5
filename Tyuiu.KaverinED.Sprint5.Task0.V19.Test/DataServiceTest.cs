using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KaverinED.Sprint5.Task0.V19.Lib;
namespace Tyuiu.KaverinED.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\C#\Tyuiu.KaverinED.Sprint5\Tyuiu.KaverinED.Sprint5.Task0.V19\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(false, fileExists);//

        }
    }
}
