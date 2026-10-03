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

            string[] f = value.Split(' ');


            for (int i = 0; i < f.Length; i++)
            {
                if (f[i].Length > 0)
                {
                    f[i] = f[i][f[i].Length - 1] + f[i].Substring(0, f[i].Length - 1);
                }
            }
            return string.Join(" ", f);
        }
    }
}
