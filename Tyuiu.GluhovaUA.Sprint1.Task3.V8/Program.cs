using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.GluhovaUA.Sprint1.Task3.V8
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Глухова У. А.| ПИНб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y, z;
            x = 2500.0;
            Console.WriteLine("Величина вклада: " + x);

            y = 20.0;
            Console.WriteLine("Процентная ставка (годовых): " + y);

            z = 30.0;
            Console.WriteLine("Срок вклада (дней): " + z);

            double r=x*(y/100.0)*(z/365.0);
            Console.WriteLine("Доход: " + Math.Round(r,3));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма по окончании срока вклада: " + ds.IncomeAmount(x, y, z));
            Console.ReadKey();
        }
    }
}
