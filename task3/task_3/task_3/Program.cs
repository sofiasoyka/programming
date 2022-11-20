using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, l, n, u, m;
            double eps = 0.001;

            Console.WriteLine("Введите значение переменной a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение переменной l");
            double.TryParse(Console.ReadLine(), out l);

            if (a == l)
                n = a;
            else
            {
                if (a < l)
                    n = Math.Cos(a);
                else
                    n = a * Math.Sin(a);
            }

            if (n > 5)
                u = 5;
            else
            {
                if (n == 5)
                    u = 5 + n * 6;
                else
                    u = Math.Cos(n);
            }

            if (Math.Abs(u * u + n) > eps)
                Console.WriteLine("Значение выражения = " + (Math.Cos(u) - u) / (u * u + n));
            else
                Console.WriteLine("Делить на ноль нельзя");
            Console.ReadKey();
        }
    }
}
