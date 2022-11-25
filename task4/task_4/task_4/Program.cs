using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* D - дискриминант
            x1 - первый корень уравнения
            x2 - второй корень уравнения */
            double a, b, c, D, x1, x2;
            double eps = 0.001;
            
            Console.WriteLine("Введите значение коэффициента при x в квадрате");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение коэффициента при x");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите значение свободного члена");
            double.TryParse(Console.ReadLine(), out c);

            D = b * b - 4 * a * c;

            if (Math.Abs(D) <= 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("Корень уравнения = " + x1);
            }
            else
            {
                if (D > eps)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    Console.WriteLine("Первый корень уравнения = " + x1);
                    Console.WriteLine("Второй корень уравнения = " + x2);
                }
                else
                    Console.WriteLine("Нет корней");
            }
            Console.ReadKey();
        }
    }
}
