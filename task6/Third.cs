using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите количество значений в массиве: ");
            int elementsMas = int.Parse(Console.ReadLine());
            int[] mas = new int[elementsMas];

            Console.WriteLine("Введите значения массива: ");

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
                if (mas[i] % 2 == 0)
                {
                    sum = sum + mas[i];

                }



            }    
            Console.WriteLine(sum);
        }

    }
}

