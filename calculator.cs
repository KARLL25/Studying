using System;


namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {   
                Console.Clear();
                double a, b;                                                // калькулятор через If else
                try
                {


                    Console.WriteLine("Введите переменные:");

                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                }catch (Exception)
                {
                    Console.WriteLine ("Не удалось преобразовать.");
                    Console.ReadLine();
                    continue;
                }

                string input;
                Console.WriteLine("Введите операцию:");

                input = Console.ReadLine();

                if (input == "+")
                {
                    Console.WriteLine(a + b);
                }
                else if (input == "-")
                {
                    Console.WriteLine(a - b);
                }
                else if (input == "*")
                {
                    Console.WriteLine(a * b);
                }
                else if (input == "/")
                {
                    if (b != 0)
                    {
                        Console.WriteLine(a / b);
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя");            // калькулятор через if else
                    }
                }
                Console.ReadLine();
            }
            /*double a, b;                                                // калькулятор через switch case

            Console.WriteLine("Введите переменные:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.Write("Выберите операцию:");

            string c = Console.ReadLine();


            switch (c)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;

                case "/":
                    if (b != 0)
                    {
                        Console.WriteLine(a / b);
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }

                    break;

                default:
                    Console.WriteLine("Надо ввести операцию");
                    break;                                               // калькулятор через switch case

            }*/
        }
    }
}
