using System;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, x, b_0, b_k, delta_b, G;
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

            for (double i = b_0; b_0 <= b_k;)
            {
                if ((Math.Abs(b_0 * b_0 - x) <= eps) ^ (Math.Abs(Math.Exp(a) + b_0) <= eps))
                    Console.WriteLine("При b = " + b_0 + ", значение G невозможно вычислить");
                else
                {
                    G = (2.4 * Math.Cos(Math.Pow(a, 3) + Math.Pow(b_0, a)) + Math.Pow(b_0 * b_0 - x, 1 / 3)) / (Math.Exp(a) + b_0);

                    if (Math.Abs(G) <= eps)
                        Console.WriteLine("При b = " + b_0 + ", значение G = 0");
                    else
                        Console.WriteLine("При b = " + b_0 + ", значение G = " + G);
                }
                b_0 += delta_b;
            }
            Console.ReadKey();
        }
    }
}
