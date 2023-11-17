using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal class Program
    {
        static int Sum(int[] mas, int i = 0)
        {
            if (i >= mas.Length)
            {
                return 0;
            }
            
            return mas[i] + Sum(mas, i + 1);

        }
        static void Main(string[] args)
        {
            int[] mas = { 5, 3, 2};
            int res = Sum(mas);
            
        }
    }
}
