using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint5.Task2.V30.Lib;
using System.IO;

namespace Tyuiu.KaverinED.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveFile()
        {
            string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint5\Tyuiu.DubrovinSN.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.csv";
            path = @"C:\Users\egorkaverin\source\repos\Tyuiu.KaverinED.Sprint5\Tyuiu.KaverinED.Sprint5.Task2.V30\bin\Debug\OutPutFileTask2.csv";
            string path2 = Directory.GetCurrentDirectory();
            Console.WriteLine(path2);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}