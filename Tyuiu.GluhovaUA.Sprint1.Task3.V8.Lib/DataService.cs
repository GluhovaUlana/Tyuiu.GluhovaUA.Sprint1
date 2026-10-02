using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GluhovaUA.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            double result = (startAmount * (percent/100.0) * (timeDays/365.0))+ startAmount;
            return Math.Round(result, 3);
        }
    }
}
