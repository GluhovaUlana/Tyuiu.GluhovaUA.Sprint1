using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GluhovaUA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            return value[value.Length - 1]+ value.Substring(0,value.Length-1);
        }
    }
}