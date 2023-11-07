using System;
using System.Linq;
using System.Threading.Tasks;

namespace main
{
    
    

    internal class Program
    {
        static void Resize<T>(ref T[] mas, int newSize) 
        {
            T[] newMas = new T[newSize];
            
            for (int i = 0; i < mas.Length && i < newMas.Length; i++)
            {
                newMas[i] = mas[i];
            }

            mas = newMas;
        }
        

        
   
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3 };
            Program.Resize(ref mas, 10);
        }

    }
}
