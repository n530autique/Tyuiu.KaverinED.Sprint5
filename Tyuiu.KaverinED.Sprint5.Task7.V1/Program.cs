using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint5.Task7.V1.Lib;

namespace Tyuiu.KaverinED.Sprint5.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            string path = @"C:\Users\egorkaverin\source\repos\Tyuiu.KaverinED.Sprint5\DataSprint5\InPutDataFileTask7V1.txt";
            Console.WriteLine("Данные в: " + path);
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V1.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Итоговые данные находятся в: " + pathSaveFile);
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.ReadKey();
        }
    }
}
