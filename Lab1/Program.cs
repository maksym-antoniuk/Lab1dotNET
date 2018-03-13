using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("~~~~~Task - 1~~~~~");

            int x1 = rand.Next(int.MinValue, int.MaxValue);
            Console.WriteLine("x1 = " + x1);

            Console.WriteLine("~~~~~Task - 2~~~~~");

            Console.WriteLine("Ваше ім‘я?");
            string str1 = Console.ReadLine();
            string str2 = "Добрий день " + str1;
            Console.WriteLine(str2);

            Console.WriteLine("~~~~~Task - 3~~~~~");

            var v1 = 'v';
            v1 = (char)64;
            Console.WriteLine("v1 = " + v1);

            Console.WriteLine("~~~~~Task - 4~~~~~");

            try
            {
                Console.WriteLine("Введите длину стороны квадрата: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Периметр Вашего квадрата: " + (4 * x));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат ввода!");
            }
            
            Console.WriteLine("~~~~~Task - 5~~~~~");

            try
            {
                Console.WriteLine("Введите первое число: ");
                double x5 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double y5 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Среднее арифметическое: " + ((x5 + y5) / 2) + "\n");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат ввода!");
            }

            Console.WriteLine("~~~~~Task - 6~~~~~");

            const double pi = 3.14;
            bool error = false;
            int R1 = 0, R2 = 0;
            while (!error)
            {
                try
                {
                    Console.WriteLine("Введите радиус первого круга: ");
                    R1 = int.Parse(Console.ReadLine());
                    if (R1 < 0)
                    {
                        Console.WriteLine("Ошибка. Радиус не может быть отрицательным.");
                        continue;
                    }
                    else error = true;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ошибка. Неверный формат ввода!");
                }
            }
            error = false;
            while (!error)
            {
                try
                {
                    Console.WriteLine("Введите радиус второго круга: ");
                    R2 = int.Parse(Console.ReadLine());
                    if (R2 < 0)
                    {
                        Console.WriteLine("Ошибка. Радиус не может быть отрицательным.");
                        continue;
                    }
                    else error = true;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ошибка. Неверный формат ввода!");
                } 
            }
            double S1 = pi * R1 * R1;
            double S2 = pi * R2 * R2;
            Console.WriteLine("Площадь первого круга = " + S1 + "\nПлощадь второго круга = " + S2 + "\nПлощадь кольца = " + Math.Abs(S1 - S2));

            Console.WriteLine("~~~~~Task - 7~~~~~");

            int num = 0;
            error = false;
            while (!error)
            {
                try
                {
                    Console.Write("Введите двузначное число: ");
                    num = int.Parse(Console.ReadLine());
                    if (num > 99 || num < 10)
                        Console.WriteLine("Ошибка. Это не двузначное число!");
                    else
                        error = true;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ошибка. Неверный формат ввода!");
                }
            }
            Console.WriteLine("Левая цифра: " + (int)(num / 10) + "\nПравая цифра: " + (num % 10));

            Console.WriteLine("~~~~~Task - 8~~~~~");

            int sec = 0;
            error = false;
            while (!error)
            {
                try
                {
                    Console.Write("Количество секунд с начала суток: ");
                    sec = int.Parse(Console.ReadLine());
                    if (sec < 0)
                        Console.WriteLine("Ошибка. Количество секунд не может быть отрицательным!");
                    else
                        error = true;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ошибка. Неверный формат ввода!");
                }
            }
            Console.WriteLine("Количество часов: " + (int)(sec / 3600));

            Console.WriteLine("~~~~~Task - 9~~~~~");

            try
            {
                Console.Write("Введите три целых числа\n1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("2: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("3: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("B " + ((b > a && b < c) ? "" : "не ") + "находится между А и С");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат ввода!");
            }
            

            Console.WriteLine("~~~~~Task - 10~~~~~");

            try
            {
                Console.WriteLine("Введите целое положительное число: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Данное число " + ((num >= 100 && num < 1000 && (num % 2) != 0) ? "" : "не ") + "является нечётным трёхзначным." + "\n");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат ввода!");
            }
            

            Console.WriteLine("~~~~~Task - 11~~~~~");

            int x11 = rand.Next(int.MinValue, int.MaxValue);
            int y11 = rand.Next(int.MinValue, int.MaxValue);

            long res = x11 + y11;
            Console.WriteLine("Сумма двух переменных типа int: " + x11 + " & " + y11 + " в переменной типа long = " + res);

            Console.WriteLine("~~~~~Task - 12~~~~~");
            long x12 = rand.Next(int.MinValue, int.MaxValue);
            long y12 = rand.Next(int.MinValue, int.MaxValue);

            byte res12 = (byte)(x12 * y12);
            Console.WriteLine("Произведение двух переменных типа long: " + x12 + " & " + y12 + " в переменной типа byte = " + res12);

            Console.ReadKey();
        }
    }
}
