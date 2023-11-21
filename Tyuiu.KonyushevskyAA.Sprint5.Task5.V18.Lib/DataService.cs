using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonyushevskyAA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double x;
                while ((line = reader.ReadLine()) != null)
                {
                    x = Convert.ToDouble(line);
                    if (Math.Abs(x) >= 10 && Math.Abs(x) <= 99)
                    {
                        res *= x;
                    }
                }
            }

            return Math.Round(res, 3);
        }
    }
}
