using System;

namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            Console.Write("Введите количество строк двумерного массива: ");
            int.TryParse(Console.ReadLine(), out M);
            Console.Write("Введите количество столбцов двумерного массива: ");
            int.TryParse(Console.ReadLine(), out N);

            int[,] array = new int[M, N];


            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Введите {j + 1} - й элемент {i + 1} - й строки массива: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (array[i, j] <= 0.001)
                        array[i, j] = 0;
                }
            }

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Массив:");
            for (int i = 0; i < M; i++)
            {
                Console.Write("         ");
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int min_last = 2147483647; // максимальное значение типа int
            int j_save = 0;
            int min, tmp;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    min = Math.Min(array[i, j], array[i, j + 1]);
                    if (min_last >= min)
                        min_last = min;
                    if (array[i, j] == min_last)
                        j_save = j;
                    if (array[i, j + 1] == min_last)
                        j_save = j + 1;
                }
                if (j_save == 0)
                    continue;
                else
                {
                    tmp = array[i, 0];
                    array[i, 0] = min_last;
                    array[i, j_save] = tmp;
                }
                min_last = 2147483647;
                j_save = 0;
            }

            Console.WriteLine();

            Console.WriteLine("Массив:");
            for (int i = 0; i < M; i++)
            {
                Console.ReadKey(true);
                Console.Write("         ");
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
