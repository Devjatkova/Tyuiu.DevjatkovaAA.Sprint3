using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DevjatkovaAA.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double S = 0;

            for (startValue = 1; startValue <= stopValue; startValue++)
            {
                S += (Math.Pow(value, 2) * startValue) + 1; 
            }
            return Math.Round(S, 3);
        }

    }
}
