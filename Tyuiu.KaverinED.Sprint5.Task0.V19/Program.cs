using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint5.Task0.V19.Lib;

namespace Tyuiu.KaverinED.Sprint5.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            int x = 2;
            Console.WriteLine("x = " + x);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();//
        }
    }
}


