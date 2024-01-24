using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KaverinED.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            
            int count = 0;
            int counter = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    
                    if (line[i] == " "[0])
                    {
                        if (counter == 8)
                        {
                            count += 1;
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;
                    }
                        
                }    
                return count;
            }
        }
    }
}