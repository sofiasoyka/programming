using System;

namespace task_10
{
    internal class Program
    {
        // получает среднюю длину слова в тексте
        static void GetAverangeLenthOfWord()
        {
            Console.WriteLine("Необходимо определить среднюю длину слова в тексте");
            Console.WriteLine();
            Console.WriteLine("Введите текст (не менее 5 предложений), используя алфавит русского языка, цифры и символы '!', ';', ':', '?', '(', ')', ',', '.'");
            Console.WriteLine();
            string str = Console.ReadLine();
            Console.WriteLine();

            int length_of_word;
            int length_of_all_words = 0;

            string[] words_in_str = str.Split(new char[] {' '});

            // массив символов, которые нужно удалить, чтобы длина слова была правильной
            char[] chars_to_delete = {'!', ';', ':', '?', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ',', '.'};

            foreach (string word in words_in_str)
            {
                length_of_word = word.Trim(chars_to_delete).Length;
                length_of_all_words += length_of_word;
            }
            Console.WriteLine("Средняя длина слова в тексте: " + length_of_all_words / words_in_str.Length);
            Console.ReadKey();
        }
        
        // меняет символ "ф" на "ту"
        static void ChangeSymbol()
        {
            Console.WriteLine("Необходимо заменить символ 'ф' на 'ту'");
            Console.WriteLine();
            Console.WriteLine("Введите текст (не менее пяти предложений), используя алфавит русского языка");
            Console.WriteLine();
            string str = Console.ReadLine();

            string final_str = ""; // строка к которой будут закидывать все символы после проверки

            foreach (char symbol in str)
            {
                if (symbol == 'ф')
                    final_str += "ту";
                else
                    final_str += symbol;
            }
            Console.WriteLine();
            Console.WriteLine("Новый текст: " + final_str);
            Console.ReadKey();
        }
        
        static void Main()
        {
            int x_cursor, y_cursor;
            int current_button = 0;

            //переменная с данными о кнопках
            ConsoleKeyInfo key;

            string[] buttons = {"Задание 1", "Задание 2", "Выход"};

            // находим центр консоли во вертикали и горизонтали
            x_cursor = Console.WindowWidth / 2;
            y_cursor = Console.WindowHeight / 2;

            do
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    Console.CursorLeft = x_cursor - (buttons[i].Length / 2);
                    Console.CursorTop = y_cursor - (buttons.Length / 2) + (i * 2);

                    if (i == current_button)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.Write("   " + buttons[i] + "   ");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                key = Console.ReadKey(true);

                if (ConsoleKey.DownArrow == key.Key)
                {
                    if (current_button == buttons.Length - 1)
                        current_button = 0;

                    else
                        current_button++;
                }

                if (ConsoleKey.UpArrow == key.Key)
                {
                    if (current_button == 0)
                        current_button = buttons.Length - 1;

                    else
                        current_button--;
                }
            }
            while (key.Key != ConsoleKey.Enter); // выйти из меню - нажать на кнопку enter

            switch (current_button)
            {
                case 0:
                    Console.Clear();
                    GetAverangeLenthOfWord();
                    Console.Clear();
                    Main();
                    break;

                case 1:
                    Console.Clear();
                    ChangeSymbol();
                    Console.Clear();
                    Main();
                    break;

                default:
                    break;
            }
        }
    }
}