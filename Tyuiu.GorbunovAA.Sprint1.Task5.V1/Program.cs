using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Вынолнил: Горбунов Александр Александрович │ ИИПб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ                                                                 *");
            Console.WriteLine("* Написать программу для вычисления расстояния между двумя точками,       *");
            Console.WriteLine("* ответ привести к целому                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            double x1; double y1; double x2; double y2;

            Console.WriteLine("Введите ординату первой точки:");

            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите абциссу первой точки:");

            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ординату второй точки:");

            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите абциссу второй точки:");

            y2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Расстояние между двумя точками - " + ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadKey();
        }
    }
}
