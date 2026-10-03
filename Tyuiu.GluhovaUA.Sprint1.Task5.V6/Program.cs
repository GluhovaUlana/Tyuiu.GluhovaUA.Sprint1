using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.GluhovaUA.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Глухова У. А.| ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Глухова У. А.| ПИНб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n               *");
            Console.WriteLine("* значение 1,2,...,7 в зависимости от того, на какой день недели          *");
            Console.WriteLine("* (понедельник, вторник,..., воскресенье) приходится k-й день             *");
            Console.WriteLine("* невисокосного года, в котором 1 января – понедельник.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int k;
            Console.WriteLine("K -целое число от 1 до 365: ");
            k = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(k));
            Console.ReadKey();
        }
    }
}
