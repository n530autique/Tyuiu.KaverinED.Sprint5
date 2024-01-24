using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KaverinED.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            Console.WriteLine(strX);
            double x = Convert.ToDouble(strX.Replace(".", ","));
            double y = Math.Pow((x * x) / (Math.Sin(x)), 3);
            double res = Math.Round(y, 3);
            return res;
        }
    }
}