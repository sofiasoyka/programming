using System; //12 v6
namespace Test123
{
    class Program
    {
        static int[,] Create2DArray(int d1, int d2)
        {
            int[,] array = new int[d1, d2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"\nВведите [{i}, {j}]-ый элемент массива:");
                    int.TryParse(Console.ReadLine(), out array[i, j]);
                }
            }
            return array;
        }
        static void SortingArray(ref int[,] arr, bool flgDirection)
        {
            int tmp;

            if (flgDirection)
            //возрастание
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        for (int i2 = i; i2 < arr.GetLength(0); i2++)
                        {
                            for (int j2 = j; j2 < arr.GetLength(1); j2++)
                            {
                                if (arr[i, j] > arr[i2, j2])
                                {
                                    tmp = arr[i2, j2];
                                    arr[i2, j2] = arr[i, j];
                                    arr[i, j] = tmp;
                                }
                            }
                        }
                    }
                }
            }
            else
            //убывание
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        for (int i2 = i; i2 < arr.GetLength(0); i2++)
                        {
                            for (int j2 = j; j2 < arr.GetLength(1); j2++)
                            {
                                if (arr[i, j] < arr[i2, j2])
                                {
                                    tmp = arr[i, j];
                                    arr[i, j] = arr[i2, j2];
                                    arr[i2, j2] = tmp;
                                }
                            }
                        }
                    }
                }
            }

        }
        static void Main()
        {
            int d1, d2;
            bool flgDir;

            Console.WriteLine("\nПервое измерение");
            int.TryParse(Console.ReadLine(), out d1);
            Console.WriteLine("\nВторое измерение");
            int.TryParse(Console.ReadLine(), out d2);

            int[,] array = Create2DArray(d1, d2);

            foreach (int num in array)
                Console.WriteLine($"|{num}|");


            Console.WriteLine("\nНаправление сортировки? (true - возрастание/false - убывание)");
            bool.TryParse(Console.ReadLine(), out flgDir);

            SortingArray(ref array, flgDir);
            foreach (int num in array)
                Console.WriteLine($"|{num}|");


            Console.ReadKey(true);
        }
    }
}