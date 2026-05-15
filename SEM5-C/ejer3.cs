using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Ingrese un numero entero: ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cant; i++)
            {
                Console.Write(i +" ");
                if (i % 2 == 0) sum +=i;
            }
            Console.WriteLine("\n\nSuma de pares: " + sum);
        }
    }
}
