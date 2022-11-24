using System;

namespace task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double w, x, F, F1; // F1 - вспомогательная переменная для счета F

            Console.WriteLine("Введите количество эелементов ряда");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введите значение переменной w");
            double.TryParse(Console.ReadLine(), out w);
            Console.WriteLine("Введите значение переменной x");
            double.TryParse(Console.ReadLine(), out x);

            if (n == 1)
            {
                F = (0.5 * w + Math.Sqrt(x * x + 5)) / (Math.Sin(1 * 2 * 3 * 4) + 3);
                Console.WriteLine("Значение F = " + F);
            }

            else
            {
                // переменные в выражении
                double v1 = 0.5;
                double v2 = x * x;
                int v3 = 5;
                int v4 = 1 * 2 * 3 * 4;
                int v5 = 3;

                F = 0;

                // вспомогательные переменные для v2
                int k2 = 3;
                int k2_1 = 2;
                int k2_2 = 3;

                int k4 = 5; // вспомогательная переменная для v4

                for (int i = 1; i <= n; i++)
                {
                    F1 = (v1 * w + Math.Sqrt(v2 + v3)) / (Math.Sin(v4) + v5);
                    F += F1;
                    v1 += 0.2;
                    v2 = Math.Pow(x, k2);
                    k2 = k2_1 * k2_2;
                    k2_1 = k2 / k2_1;
                    k2_2 = k2;
                    v3 += 5;
                    v4 *= k4;
                    k4 += 1;
                    v5 += 3;
                }

                Console.WriteLine("Значение F = " + F);
            }
            Console.ReadKey();
        }

    }
}
