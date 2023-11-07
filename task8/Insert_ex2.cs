using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace main
{
    
    

    internal class Program
    {
        

        static void Insert(ref int[] mas, int value, int index)
        {
            int[] newMas = new int[mas.Length + 1];
            newMas[index] = value;

            for (int i = 0; i < index; i++)
                newMas[i] = mas[i];
            
            for (int i = index; i < mas.Length; i++)
                newMas[i+1] = mas[i];
            
            mas = newMas;
        }

        static void AddFirst(ref int[] mas, int value)
        {
            Insert(ref mas, value, 0);
        }
   
        static void AddLast(ref int[] mas, int value)
        {
            Insert(ref mas, value, mas.Length);
        }
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3 , 2};
            /*Insert(ref mas, -5,2);*/          // по индексу

            //AddFirst(ref mas, 10);            // первое значение
            
            AddLast(ref mas, -5);               // последнее значение
            
          
        }

    }
}
