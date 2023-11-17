using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal class Program
    {
        static void PrinArray(int[] mas, int i = 0)
        {
            if (i < mas.Length)
            {
                Console.WriteLine(mas[i]);
                PrinArray(mas, i+1);
            }
            
        }
        static void Main(string[] args)
        {
            int[] mas = { 5, 3, 2};
            PrinArray(mas);
            
        }
    }
}
