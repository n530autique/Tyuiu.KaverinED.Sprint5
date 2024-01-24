using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Linq;


namespace Tyuiu.KaverinED.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    double number = Convert.ToDouble(line);
                    if (number % 1 == 0)
                    {
                        for (int i = 1; i <= number; i++)
                        {
                            res *= number;
                        }
                    }
                }
            }
            return res;
        }
    }
}
