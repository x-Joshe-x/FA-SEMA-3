using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejercicio3
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE EL NUMERO 1: ");
            double NUM1 = double.Parse(Console.ReadLine());

            Console.Write("INGRESE EL NUMERO 2: ");
            double NUM2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nSUMA: {NUM1 + NUM2}");
            Console.WriteLine($"\nRESTA: {NUM1 - NUM2}");
            Console.WriteLine($"\nMULTIPLICACION: {NUM1 * NUM2}");
            Console.WriteLine($"\nDIVISION: {NUM1 / NUM2}");
        }
    }
}
