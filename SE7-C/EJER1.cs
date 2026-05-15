using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class EJER1
    {
        static void Main(string[] args)
        {
            int cantidad, par = 0, impar = 0;
            do
            {
                Console.Write("Ingrese un numero: ");
                cantidad = int.Parse(Console.ReadLine());
                
                if (cantidad > 0) 
                {
                    if (cantidad % 2 == 0) par++;
                    else if (cantidad % 2 != 0) par++;
                }
            } while (cantidad > 0);
            Console.WriteLine("Cantidad de pares: " + par);
            Console.WriteLine("Cantidad de imapres: " + impar);
        }
    }
}

