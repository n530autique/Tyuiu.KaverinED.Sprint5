using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KaverinED.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V1.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    line = line.Replace(i.ToString(), "");
                }
                File.AppendAllText(pathSaveFile, line);
            }
            return pathSaveFile;
        }
    }
}