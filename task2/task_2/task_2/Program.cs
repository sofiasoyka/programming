using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double phrase_1, phrase_2, action_1, action_2, action_3, action_4, action_5, action_6, action_7, action_8, action_9, action_10, action_11;
            phrase_1 = Math.Sqrt((Math.Pow((((58.0 * 15.0 + 4.0) / 15.0) - ((56.0 * 24.0 + 7.0) / 24.0)), 1.0 / 3.0) / 0.8) + ((2.0 * 9.0 + 1.0) / 9.0 * 0.225)) /
                (((8.0 * 4.0 + 3.0) / 4.0) * (3.0 / 5.0)) + (Math.Pow((Math.Pow(1.0 / 0.13, 3.0)), 1.0 / 5.0)) + (3.1415926 / 3.0);
            Console.WriteLine("Значение выражения = " + phrase_1);
            action_1 = ((58.0 * 15.0 + 4.0) / 15.0) - ((56.0 * 24.0 + 7.0) / 24.0);
            action_2 = Math.Pow(action_1, 1.0 / 3.0);
            action_3 = action_2 / 0.8;
            action_4 = (2.0 * 9.0 + 1.0) / 9.0 * 0.225;
            action_5 = action_3 + action_4;
            action_6 = Math.Sqrt(action_5);
            action_7 = ((8.0 * 4.0 + 3.0) / 4.0) * (3.0 / 5.0);
            action_8 = action_6 / action_7;
            action_9 = Math.Pow(1.0 / 0.13, 3.0);
            action_10 = Math.Pow(action_9, 1.0 / 5.0);
            action_11 = 3.1415926 / 3.0;
            phrase_2 = action_8 + action_10 + action_11;
            Console.WriteLine("Значение выражения = " + phrase_2);
            Console.ReadKey();
        }
    }
}

