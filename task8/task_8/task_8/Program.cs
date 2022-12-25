using System;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity;

            Console.Write("Введите количество элементов одномерного массива: ");
            int.TryParse(Console.ReadLine(), out quantity);

            double[] array = new double[quantity];

            int i = 0;

            while (i + 1 <= quantity)
            {
                Console.Write($"Введите {i + 1}-й элемент одномерного массива: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
                if (array[i] <= 0.001)
                    array[i] = 0;
                i += 1;
            }

            Console.Write("Массив:  ");
            foreach (double elem in array)
            {
                Console.Write(elem + "  ");
            }
            Console.WriteLine();

            Array.Sort(array);

            i = 0;
            int count = 1;
            int max_count = 0;
            double max_char = 0;

            while (i != quantity - 1)
            {
                if (array[i] == array[i + 1])
                    count += 1;
                else
                {
                    if (max_count < count)
                    {
                        max_count = count;
                        max_char = array[i];
                    }
                    count = 1;
                }
                i += 1;
            }

            if (max_count == 1)
                Console.WriteLine("Ошибка - числа в массиве не повторяются");
            else
                Console.WriteLine($"Число, которое встречается в массиве наибольшее количество раз: {max_char}");
            
            Console.ReadKey();
        }
    }
}
