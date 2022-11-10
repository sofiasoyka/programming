using System;

namespace задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //общее задание
            double abs, acos, asin, atan, atan2_1, atan2_2, ceiling, cos, cosh, exp, floor, ieee_remainder_1, ieee_remainder_2, log_number, log_base, log10, max_1, max_2, min_1,
                min_2, pow_number, pow_degree, round_number_1, round_number_2, sign, sin, sinh, sqrt, tan, tanh, truncate;
            int big_mul_1, big_mul_2, res, div_rem_1, div_rem_2, round_sign, number;

            Console.WriteLine("Введите число для нахождения его модуля.");
            double.TryParse(Console.ReadLine(), out abs);
            Console.WriteLine("Введите число для определения арккосинуса в диапазоне [-1;1].");
            double.TryParse(Console.ReadLine(), out acos);
            Console.WriteLine("Введите число для определения арксинуса в диапазоне [-1;1].");
            double.TryParse(Console.ReadLine(), out asin);
            Console.WriteLine("Введите число для определения арктангенса.");
            double.TryParse(Console.ReadLine(), out atan);
            Console.WriteLine("Введите первое число для нахождения угла, тангенс которого равен отношению двух чисел.");
            double.TryParse(Console.ReadLine(), out atan2_1);
            Console.WriteLine("Введите второе число для нахождения угла, тангенс которого равен отношению двух чисел.");
            double.TryParse(Console.ReadLine(), out atan2_2);
            Console.WriteLine("Введите первое число для произведения двух чисел.");
            int.TryParse(Console.ReadLine(), out big_mul_1);
            Console.WriteLine("Введите второе число для произведения двух чисел.");
            int.TryParse(Console.ReadLine(), out big_mul_2);
            Console.WriteLine("Введите число для нахождения наименьшлего целого числа, которое больше или равно введенному числу.");
            double.TryParse(Console.ReadLine(), out ceiling);
            Console.WriteLine("Введите значение угла в радианах для нахождения его косинуса.");
            double.TryParse(Console.ReadLine(), out cos);
            Console.WriteLine("Введите значение угла в радианах для нахождения его гиперболического косинуса.");
            double.TryParse(Console.ReadLine(), out cosh);
            Console.WriteLine("Введите делимое для нахождения разности двух чисел.");
            int.TryParse(Console.ReadLine(), out div_rem_1);
            Console.WriteLine("Введите делитель для нахождения разности двух чисел.");
            int.TryParse(Console.ReadLine(), out div_rem_2);
            Console.WriteLine("Введите степень для нахождения значения числа е в этой степени.");
            double.TryParse(Console.ReadLine(), out exp);
            Console.WriteLine("Введите число для нахождения наибольшего целого числа, которое меньше или равно введенному числу.");
            double.TryParse(Console.ReadLine(), out floor);
            Console.WriteLine("Введите делимое для нахождения остатка разности двух чисел.");
            double.TryParse(Console.ReadLine(), out ieee_remainder_1);
            Console.WriteLine("Введите делимое для нахождения остатка разности двух чисел.");
            double.TryParse(Console.ReadLine(), out ieee_remainder_2);
            Console.WriteLine("Введите число для нахождения его логарифма по введенному основанию.");
            double.TryParse(Console.ReadLine(), out log_number);
            Console.WriteLine("Введите основание логарифма.");
            double.TryParse(Console.ReadLine(), out log_base);
            Console.WriteLine("Введите число для нахождения логарифма с основанием 10.");
            double.TryParse(Console.ReadLine(), out log10);
            Console.WriteLine("Введите первое число для нахождение наибольшего из двух.");
            double.TryParse(Console.ReadLine(), out max_1);
            Console.WriteLine("Введите второе число для нахождение наибольшего из двух.");
            double.TryParse(Console.ReadLine(), out max_2);
            Console.WriteLine("Введите первое число для нахождение наименьшего из двух.");
            double.TryParse(Console.ReadLine(), out min_1);
            Console.WriteLine("Введите второе число для нахождение наименьшего из двух.");
            double.TryParse(Console.ReadLine(), out min_2);
            Console.WriteLine("Введите число для нахождения значения этого числа в указанной степени.");
            double.TryParse(Console.ReadLine(), out pow_number);
            Console.WriteLine("Введите степень.");
            double.TryParse(Console.ReadLine(), out pow_degree);
            Console.WriteLine("Введите число для округления его до ближайшего целого или до указанного количества знаков. Если вы хотите округлить до целого - введите 1, " +
                "потом само число. Если хотите округлить до указанного количества знаков - введите 2, потом число, потом количество знаков.");
            int.TryParse(Console.ReadLine(), out number);
            round_number_1 = 0;
            round_number_2 = 0;
            round_sign = 0;
            if (number == 1)
                double.TryParse(Console.ReadLine(), out round_number_1);
            if (number == 2)
            {
                double.TryParse(Console.ReadLine(), out round_number_2);
                int.TryParse(Console.ReadLine(), out round_sign);
            }
            Console.WriteLine("Введите число для определения его знака. Если число меньше 0 - выведется -1, если число равно 0 - 0, если число больше 0 - +1.");
            double.TryParse(Console.ReadLine(), out sign);
            Console.WriteLine("Введите значение угла в радианах для нахождения его синуса.");
            double.TryParse(Console.ReadLine(), out sin);
            Console.WriteLine("Введите значение угла в радианах для нахождения его гиперболического синуса.");
            double.TryParse(Console.ReadLine(), out sinh);
            Console.WriteLine("Введите число для нахождения его квадратного корня.");
            double.TryParse(Console.ReadLine(), out sqrt);
            Console.WriteLine("Введите значение угла в радианах для нахождения его тангенса.");
            double.TryParse(Console.ReadLine(), out tan);
            Console.WriteLine("Введите значение угла в радианах для нахождения его гиперболического тангенса.");
            double.TryParse(Console.ReadLine(), out tanh);
            Console.WriteLine("Введите число для нахождения его целого числа.");
            double.TryParse(Console.ReadLine(), out truncate);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Нажмите Enter для вывода результатов.");
            Console.ReadKey(true);

            Console.WriteLine("Модуль " + abs + " = " + (double)Math.Abs(abs) + ".");
            Console.WriteLine("Арккосинус " + acos + " = " + (double)Math.Acos(acos) + ".");
            Console.WriteLine("Арксинус " + asin + " = " + (double)Math.Asin(asin) + ".");
            Console.WriteLine("Арктангенс " + atan + " = " + (double)Math.Atan(atan) + ".");
            Console.WriteLine("Угол, тангенс которого равен отношению " + atan2_1 + " к " + atan2_2 + ", = " + (double)Math.Atan2(atan2_1, atan2_2) + ".");
            Console.WriteLine("Произведение " + big_mul_1 + " и " + big_mul_2 + " = " + (int)Math.BigMul(big_mul_1, big_mul_2) + ".");
            Console.WriteLine("Наименьшее целое число, которое больше или равно " + ceiling + ", = " + (double)Math.Ceiling(ceiling) + ".");
            Console.WriteLine("Косинус " + cos + " = " + (double)Math.Cos(cos) + ".");
            Console.WriteLine("Гиперболический косинус " + cosh + " = " + (double)Math.Cosh(cosh) + ".");
            Console.WriteLine("Разность " + div_rem_1 + " и " + div_rem_2 + " = " + (int)Math.DivRem(div_rem_1, div_rem_2, out res) + ".");
            Console.WriteLine("Число е в " + exp + " степени = " + (double)Math.Exp(exp) + ".");
            Console.WriteLine("Набольшее целое число, которое меньше или равно " + floor + ", = " + (double)Math.Floor(floor) + ".");
            Console.WriteLine("Остаток от деления " + ieee_remainder_1 + " на " + ieee_remainder_2 + " = " + (double)Math.IEEERemainder(ieee_remainder_1, ieee_remainder_2) + ".");
            Console.WriteLine("Логарифм " + log_number + " с основанием " + log_base + " = " + (double)Math.Log(log_number, log_base) + ".");
            Console.WriteLine("Десятичный логарифм " + log10 + " = " + (double)Math.Log10(log10) + ".");
            Console.WriteLine("Наибольшее число из " + max_1 + " и " + max_2 + " = " + (double)Math.Max(max_1, max_2) + ".");
            Console.WriteLine("Наименьшее число из " + min_1 + " и " + min_2 + " = " + (double)Math.Min(min_1, min_2) + ".");
            Console.WriteLine("Число " + pow_number + " в степени " + pow_degree + " = " + (double)Math.Pow(pow_number, pow_degree) + ".");
            if (number == 1)
                Console.WriteLine("Округление " + round_number_1 + " до ближайшего целого числа = " + (double)Math.Round(round_number_1) + ".");
            if (number == 2)
                Console.WriteLine("Округление " + round_number_2 + " до " + round_sign + " знака после запятой = " + (double)Math.Round(round_number_2, round_sign) + ".");
            Console.WriteLine("Знак " + sign + " - " + (double)Math.Sign(sign) + ".");
            Console.WriteLine("Синус " + sin + " = " + (double)Math.Sin(sin) + ".");
            Console.WriteLine("Гиперболический синус " + sinh + " = " + (double)Math.Sinh(sinh) + ".");
            Console.WriteLine("Квадратный корень " + sqrt + " = " + (double)Math.Sqrt(sqrt) + ".");
            Console.WriteLine("Тангенс " + tan + " = " + (double)Math.Tan(tan) + ".");
            Console.WriteLine("Гиперболический тангенс " + tanh + " = " + (double)Math.Tanh(tanh) + ".");
            Console.WriteLine("Целое число числа " + truncate + " = " + (double)Math.Truncate(truncate) + ".");
            Console.ReadKey(true);

            //индивидуальное задание
            double a, b, c, d, e;
            Console.WriteLine("Введите последовательно 5 чисел.");
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double.TryParse(Console.ReadLine(), out d);
            double.TryParse(Console.ReadLine(), out e);

            if ((a >= b) & (a >= c) & (a >= d) & (a >= e))
                Console.WriteLine("Максимальное значение из 5 введенных чисел = " + a);
            else
            {
                if ((b >= a) & (b >= c) & (b >= d) & (b >= e))
                    Console.WriteLine("Максимальное значение из 5 введенных чисел = " + b);
                else
                {
                    if ((c >= a) & (c >= b) & (c >= d) & (c >= e))
                        Console.WriteLine("Максимальное значение из 5 введенных чисел = " + c);
                    else
                    {
                        if ((d >= a) & (d >= b) & (d >= c) & (d >= e))
                            Console.WriteLine("Максимальное значение из 5 введенных чисел = " + d);
                        else
                            Console.WriteLine("Максимальное значение из 5 введенных чисел = " + e);
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
