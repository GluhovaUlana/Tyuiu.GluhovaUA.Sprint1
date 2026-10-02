using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint1.Task2.V22.Lib;
namespace Tyuiu.GluhovaUA.Sprint1.Task2.V22
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Глухова У. А.| ПИНб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать прогамму, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет среднее значение из трех чисел и печатает результат на экране.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x,y,z;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CalculateAVGValue(x, y, z ));
            Console.ReadLine();
        }
    }
}

