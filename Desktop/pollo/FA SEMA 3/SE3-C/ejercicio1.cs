using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            string n, c;
            Console.Write("ingrese el nombre del estudiante: ");
            n = Console.ReadLine();
            Console.Write("\ningrese el nombre de la carrera: ");
            c = Console.ReadLine();

            Console.WriteLine("----------IMPRESION CON +-------------");

            Console.WriteLine(n+", bienvenido a la carrera de "+c);
            Console.WriteLine("----------IMPRESION CON $-------------");
            Console.WriteLine($"{n}, bienvenido a la carrera de {c}"); 
            Console.ReadKey(); 
        }
    }
}
