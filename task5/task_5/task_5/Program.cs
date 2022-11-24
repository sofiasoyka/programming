using System;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код операции (от 0 до 3)");
            byte.TryParse(Console.ReadLine(), out byte s); // вводимый код операции
            switch(s)
            {
                case 0:
                    Console.WriteLine("Результат операции sin(0) = " + Math.Sin(0));
                    break;
                case 1:
                    Console.WriteLine("Результат операции tg(1) = " + Math.Tan(1));
                    break;
                case 2:
                    Console.WriteLine("Результат операции ln(2) = " + Math.Log(2));
                    break;
                case 3:
                    Console.WriteLine("Результат операции sqrt(3) = " + Math.Sqrt(3));
                    break;
                default:
                    Console.WriteLine("Введен неверный код операции");
                    break;
            }
            Console.ReadLine();
        }
    }
}