using System;


namespace even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double even = 0;       // четные
            double odd = 0;        // нечетные

            Console.WriteLine("Укажите начало лимита");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Укажите лимит диапазона:");
            int limit = int.Parse(Console.ReadLine());

            while (count <= limit)
            {
                if (count % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                count++;

            }
            Console.WriteLine("Кол-во четных: " + even);
            Console.WriteLine("Кол-во нечетных: " + odd);
        }
    }
}
