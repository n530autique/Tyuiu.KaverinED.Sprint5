using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint5.Task6.V30.Lib;

namespace Tyuiu.KaverinED.Sprint5.Task6.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                 
            string path = @"C:\Users\egorkaverin\source\repos\Tyuiu.KaverinED.Sprint5\DataSprint5\InPutDataFileTask6V30.txt";
            Console.WriteLine("Данные в: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
