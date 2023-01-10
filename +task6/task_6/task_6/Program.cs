using System;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, x, b_0, b_k, delta_b, G, b;
            double eps = 0.001;

            Console.WriteLine("Введите значение переменной а");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение переменной x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите начальное значение b");
            double.TryParse(Console.ReadLine(), out b_0);
            Console.WriteLine("Введите конечное значение b");
            double.TryParse(Console.ReadLine(), out b_k);
            Console.WriteLine("Введите значение шага");
            double.TryParse(Console.ReadLine(), out delta_b);

            b = b_0;

            while (b <= b_k)
            {
                if (Math.Abs(Math.Exp(a) + b) <= eps)
                    Console.WriteLine("При b = " + b + ", значение G невозможно вычислить");
                else
                {
                    G = (2.4 * Math.Cos(Math.Pow(a, 3.0) + Math.Pow(b, a)) + Math.Pow(b * b - x, 1 / 3)) / (Math.Exp(a) + b);

                    if (Math.Abs(G) <= eps)
                        Console.WriteLine("При b = " + b + ", значение G = 0");
                    else
                        Console.WriteLine("При b = " + b + ", значение G = " + G);
                }
                b += delta_b;
            }
            Console.ReadKey();
        }
    }
}
