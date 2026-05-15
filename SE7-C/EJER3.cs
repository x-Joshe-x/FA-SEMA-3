using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class EJER3
    {
        static void Main(string[] args)
        {
            string continuar;
            int num, suma = 0, i = 1;
            do
            {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                do {
                    suma += i;
                    i++;
                } while (i <= num);

                Console.WriteLine($"La suma del rango 1 - {num} es {suma}");
                Console.Write("¿Desea continuar? (presione s): ");
                continuar = Console.ReadLine();
            } while (continuar == "s");
        }
    }
}
