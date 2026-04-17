using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejercicio4
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE UN NUMERO DECIMAL: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"RAIZ CUADRADA: {Math.Sqrt(num)}");
            Console.WriteLine($"NUMERO REDONDEADO: {Math.Round(num)}");
            Console.WriteLine($"AL CUBO: {Math.Pow(num,3)}");
            Console.WriteLine($"RAIZ CUBICA: {Math.Pow(num,1/3d)}");


        }
    }
}
