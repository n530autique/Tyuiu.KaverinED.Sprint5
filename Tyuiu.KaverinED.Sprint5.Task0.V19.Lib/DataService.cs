using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KaverinED.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double f = Math.Round((2 * x * x - 1) / (Math.Sqrt(x * x - 2)), 2);
            File.WriteAllText(path, Convert.ToString(f));
            return path;   //   
        }
    }
}
