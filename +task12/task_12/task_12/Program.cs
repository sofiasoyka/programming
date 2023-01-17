using System;

namespace task_12
{
    internal class Program
    {
        // сортирует двумерный массив по возрастанию/убыванию
        static void SortArray(ref int[,] array, bool flag)
        {
            int tmp;

            // по возрастанию
            if (flag)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int run = 0; run < array.GetLength(1) - 1; run++)
                    {
                        for (int j = 0; j < array.GetLength(1) - 1; j++)
                        {
                            if (array[i, j] > array[i, j + 1])
                            {
                                tmp = array[i, j];
                                array[i, j] = array[i, j + 1];
                                array[i, j + 1] = tmp;
                            }
                        }
                    }
                }
            }

            // по убыванию
            else
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int run = 0; run < array.GetLength(1) - 1; run++)
                    {
                        for (int j = 0; j < array.GetLength(1) - 1; j++)
                        {
                            if (array[i, j] < array[i, j + 1])
                            {
                                tmp = array[i, j];
                                array[i, j] = array[i, j + 1];
                                array[i, j + 1] = tmp;
                            }
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк двумерного массива: ");
            int S = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов двумерного массива: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[S, C];
            bool flag = true;

            for (int i = 0; i < S; i++)
            {
                for(int j = 0; j < C; j++)
                {
                    Console.Write($"Введите {j + 1} - й элемент {i + 1} - й строки: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < S; i++)
            {
                for (int j = 0; j < C; j++)
                    Console.Write(array[i, j] + "\t");
                Console.WriteLine();
            }

            Console.WriteLine("\nЕсли вы хотите отсортировать все строки массива по возрастанию, напишите 'a'.");
            Console.WriteLine("Если вы хотите отсортировать все строки массива по убыванию, напишите 'b'.");
            Console.WriteLine("Если вы хотите отсортировать все строки массива, чередуя возрастание и убывание, напишите 'c'.");
            Console.WriteLine("Если вы хотите отсортировать все строки массива, чередуя убывание и возрастание, напишите 'd'.");
            string choice = Console.ReadLine();

            if (choice == "a" | choice == "c" | choice == "b" | choice == "d")
            {
                if (choice == "a" | choice == "c")
                    flag = true;

                if (choice == "b" | choice == "d")
                    flag = false;

                SortArray(ref array, flag);

                Console.WriteLine("\nОтсортированный массив:");
                for (int i = 0; i < S; i++)
                {
                    for (int j = 0; j < C; j++)
                        Console.Write(array[i, j] + "\t");
                    Console.WriteLine();
                }

                if (choice == "c" | choice == "d")
                {
                    if (choice == "c")
                        flag = false;

                    if (choice == "d")
                        flag = true;

                    SortArray(ref array, flag);

                    Console.WriteLine("\nПовторно отсортированный массив:");
                    for (int i = 0; i < S; i++)
                    {
                        for (int j = 0; j < C; j++)
                            Console.Write(array[i, j] + "\t");
                        Console.WriteLine();
                    }
                }
            }

            else
                Console.WriteLine("\nНеверный символ");

            Console.ReadKey();
        }
    }
}
