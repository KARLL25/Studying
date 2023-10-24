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
            int[] mas = new int[5];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
                
                Console.WriteLine("\t", mas[i]);
            }
        }
    }
}
