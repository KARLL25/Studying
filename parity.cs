using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;                            // 2 task

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
            
        }
    }
