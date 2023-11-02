using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void PrintLine(char symbol, uint symbolsCount)
        {
            
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.WriteLine(symbol);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("\nВведите количество: ");
            uint symbolsCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol,symbolsCount);
            Console.ReadLine();
        }
    }
}

