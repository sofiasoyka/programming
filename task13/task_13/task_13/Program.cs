using System;
using System.IO;

namespace task_13
{
    internal class Program
    {
        public static string file_path1 = Directory.GetCurrentDirectory() + "\\File1.txt";
        public static string file_path2 = Directory.GetCurrentDirectory() + "\\File2.txt";

        static void WriteFile(string path)
        {
            StreamWriter stream_writer;
            int number_of_words;

            //открываем поток (false - добавление строк, true - замена строк)
            stream_writer = new StreamWriter(path, false);

            Console.WriteLine();
            Console.Write("Сколько слов в файле: ");
            int.TryParse(Console.ReadLine(), out number_of_words);

            Console.WriteLine();
            Console.WriteLine("Ввод слов: ");
            for (int i = 0; i < number_of_words; i++)
            {
                Console.Write("Ввод " + (i + 1) + " слова: ");
                stream_writer.WriteLine(Console.ReadLine()); //написать строку в файл ранее
            }

            stream_writer.Close();

            Console.WriteLine();
            Console.WriteLine("Конец записи.");
            Console.ReadKey(true);
            Console.Clear();
        }
        static string[] ReadFile(string path, string path2)
        {
            StreamReader stream_reader;
            StreamWriter stream_writer;
            stream_reader = new StreamReader(path);
            stream_writer = new StreamWriter(path2, false);

            string[] words_file = stream_reader.ReadToEnd().Split(new char[] {'\n'});
            stream_reader.Close();

            Array.Sort(words_file);

            foreach (string word in words_file)
                stream_writer.WriteLine(word);

            stream_writer.Close();
            return words_file;
        }
        static void Main()
        {
            string[] str_array;

            WriteFile(file_path1);

            if (!File.Exists(file_path1))
            {
                Console.WriteLine("Ошибка - файла не существует");
            }

            str_array = ReadFile(file_path1, file_path2);

            if (str_array.Length > Console.WindowHeight - 2)
            {
                for (int i = 0, word_count_on_screen = 0; i < str_array.Length; i++)
                {
                    if (word_count_on_screen < Console.WindowHeight - 2)
                    {
                        Console.WriteLine(str_array[i]);
                        word_count_on_screen++;
                    }

                    else
                    {
                        Console.WriteLine("Элементов слишком много! Переход на следующую страницу");

                        Console.ReadKey(true);
                        Console.Clear();

                        word_count_on_screen = 0;
                    }
                }
            }

            else
            {
                foreach (string word in str_array)
                    if (word != "")
                        Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.WriteLine("Конец вывода");
            Console.ReadKey(true);
        }
    }
}
