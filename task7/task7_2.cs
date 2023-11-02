using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_2
{
    internal class Program
    {
        static int IndexOf(int[] array, int value)
        {
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1; 
        }
        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                myArray[i]= rnd.Next(minValue, maxValue);
            }
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] mas = GetRandomArray(10, -20, 10);

            
            int res = IndexOf(mas, 9);
            Console.WriteLine(res);
        }
    }
    
}
