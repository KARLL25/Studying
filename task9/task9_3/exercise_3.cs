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
        static int Sum(int value)
        {
           if (value < 10)
            
                return value;
             

            return value % 10 + Sum(value / 10);
           
        }
        static void Main(string[] args)
        {
            int value = 522;
            

            int res = Sum(value);

        }
    }
}
