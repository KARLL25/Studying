using System;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;              /* 1 задание */
            int b = 10;

            double c = a + b;

            Console.WriteLine(c / 2);  /* 1 задание */



            Console.Write("Введите первое число: "); /* 2 задание */
            string num1 = Console.ReadLine();

            Console.Write("Введите второе число: ");
            string num2 = Console.ReadLine();

            Console.Write("Введите третье число: ");
            string num3 = Console.ReadLine();

            int e = Convert.ToInt32(num1);
            int f = Convert.ToInt32(num2);
            int g = Convert.ToInt32(num3);

            int sum = e + f + g;
            int mult = e * f * g;

            Console.WriteLine("Значение суммы: " + sum);
            Console.WriteLine("Произведение чисел: " + mult); /* 2 задание */



            Console.Write("Введите рубли: ");  /* 3 задание */
            string rub = Console.ReadLine();

            int rubls = int.Parse(rub);

            double conv_us = rubls / 96.99;
            double conv_eu = rubls / 103.04;

            Console.WriteLine("Конвертер из рублей в доллары: " + conv_us);
            Console.WriteLine("Конвертер из рублей в евро: " + conv_eu);     /* 3 задание   */


        }
    }
}
