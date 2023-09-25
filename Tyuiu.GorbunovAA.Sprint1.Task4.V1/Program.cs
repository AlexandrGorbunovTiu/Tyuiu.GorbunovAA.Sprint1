using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Вынолнил: Горбунов Александр Александрович │ ИИПб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ                                                                 *");
            Console.WriteLine("* Написать программу для вычисления выражения 1 / (x + 2) ** 2,           *");
            Console.WriteLine("* округленного до 3 знаков после запятой                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int x;

            Console.WriteLine("Введите значение Х:");

            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("1 / (x + 2) ** 2 = " + ds.Calculate(x));
            Console.ReadLine();
        }
    }
}
