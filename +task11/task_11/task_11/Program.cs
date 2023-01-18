using System;

namespace task_11
{
    internal class Program
    {
        // увеличивает/уменьшает размерность одномерного массива на 1
        static double[] ChangeDementionOfArray(double[] array, bool flag)
        {
            // увеличивает размерность массива на 1
            if (flag)
            {
                double[] modified_array = new double[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                    modified_array[i] = array[i];

                modified_array[array.Length] = 0;

                return modified_array;
            }

            // уменьшает размерность массива на 1
            else
            {
                double[] modified_array = new double[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                    modified_array[i] = array[i];

                return modified_array;
            }
        }
        static void Main()
        {
            Console.Write("Введите количество элементов одномерного массива: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите элементы одномерного массива\n");

            double[] array = new double[quantity];
            bool flag;

            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Введите {i + 1} - й элемент массива: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("\nМассив:  ");
            for (int i = 0; i < quantity; i++)
                Console.Write(array[i] + "  ");

            Console.WriteLine("\n\nЕсли вы хотите увеличить размерность массива на 1, напишите '+'.");
            Console.WriteLine("Если вы хотите уменьшить размерность массива на 1, напишите '-'.");
            string choice = Console.ReadLine();

            // проверка ввода правильного символа
            if (choice == "+" | choice == "-")
            {
                if (choice == "+")
                    flag = true;
                else
                    flag = false;

                Console.WriteLine("\nЧтобы получить результат, нажмите Enter");
                Console.ReadKey();

                double[] modified_array = ChangeDementionOfArray(array, flag);

                Console.Write("\nМассив с измененной размерностью:  ");
                for (int i = 0; i < modified_array.Length; i++)
                    Console.Write(modified_array[i] + "  ");

                Console.WriteLine();
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("\nНеверный символ");
                Console.ReadKey();
            }
        }
    }
}
