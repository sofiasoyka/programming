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

            Console.WriteLine();

            double[] array = new double[quantity];

            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент одномерного массива: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
                if (array[i] <= 0.001)
                    array[i] = 0;
            }

            Console.WriteLine();

            Console.Write("Массив:  ");
            foreach (double elem in array)
            {
                Console.Write(elem + "  ");
            }
            Console.WriteLine();

            double[,] number_count = new double[2, quantity]; // создаем новый двумерный массив для записи количества нахождений числа

            for (int f = 0; f < quantity; f++)
            {
                for (int j = 0; j < quantity; j++)
                {
                    if (array[f] == array[j])
                    {
                        // [0, i] = число и [1, i] = сколько раз оно встречалось
                        number_count[0, j] = array[j];
                        number_count[1, j] = number_count[1, j] + 1;
                        break;
                    }
                }
            }

            int one_counter = 0;
            double tmp, tmp_id;

            for (int k = 0; k < quantity; k++)
            {
                if (number_count[1, k] == 1)
                    one_counter++; // запоминаем встречу число 1 раз

                for (int g = k + 1; g < quantity; g++)
                {
                    // сортируем по возрастанию количество нахождений числа
                    // перемещаем само число над его количеством
                    if (number_count[1, k] > number_count[1, g])
                    {
                        tmp = number_count[1, g];
                        tmp_id = number_count[0, g];
                        number_count[1, g] = number_count[1, k];
                        number_count[0, g] = number_count[0, k];
                        number_count[1, k] = tmp;
                        number_count[0, k] = tmp_id;
                    }
                }
            }

            Console.WriteLine();

            // печатаем вывод, исключая незаполненный массив
            // проверяем не встречаются ли все числа по 1 разу
            for (int q = 0; q < quantity; q++)
            {
                if ((number_count[0, q] != 0) & (number_count[1, q] != 0) & (one_counter != quantity) & (number_count[1, q] == number_count[1, quantity - 1]))
                {
                    if (number_count[1, q] == 2 | number_count[1, q] == 3 | number_count[1, q] == 4)
                        Console.WriteLine($"Число {number_count[0, q]} встречается {number_count[1, q]} раза");
                    else
                        Console.WriteLine($"Число {number_count[0, q]} встречается {number_count[1, q]} раз");
                }

                else if (one_counter == quantity)
                {
                    Console.WriteLine("Ошибка - числа в массиве не повторяются");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
