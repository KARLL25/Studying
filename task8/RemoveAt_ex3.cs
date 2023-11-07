using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_3
{
    internal class Program
    {
        static void RemoveAt(ref int[] mas, int index)
        {
            int[] newMas = new int[mas.Length - 1];

            for (int i = 0; i < index; i++)
                newMas[i] = mas[i];

            for (int i = index + 1; i < mas.Length; i++)
                newMas[i - 1] = mas[i];

            mas = newMas;
        }


        static void RemoveFirst(ref int[] mas, int index)
        {
            RemoveAt(ref mas, 0);
        }

        static void RemoveLast(ref int[] mas, int index)
        {
            RemoveAt(ref mas, mas.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4 };
            /* RemoveAt(ref mas, 2);*/       // по индексу

            /*RemoveFirst(ref mas, 0);*/    // первое значение

            RemoveLast(ref mas, 4);         // последнее значение
        }
    }
}
