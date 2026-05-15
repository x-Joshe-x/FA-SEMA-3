using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class EJER2
    {
        static void Main(string[] args)
        {
            int intentos = 3;
            Random rnd = new Random();

            int aleatorio = rnd.Next(1,21);
            int num;

            Console.WriteLine("BIENDENIDO AL JUEGO ADIVINADOR");

            Console.WriteLine("INSTRUCCIONES: ");
            Console.WriteLine("1. Ud. tiene 3 intentos. ");
            Console.WriteLine("2. El numero a adivinar esta en el rango de 1-20");

            do 
            {
                Console.Write("Ingrese el numero: ");
                num = int.Parse(Console.ReadLine());

                if (num == aleatorio)
                {
                    Console.WriteLine("Correcto adivinaste el numero " + aleatorio);
                    break;
                }
                if(num > aleatorio)
                {
                    Console.WriteLine("Incorrecto, el numero es menor: ");
                    intentos--;
                }
                else if(num < aleatorio)
                {
                    Console.WriteLine("Incorrecto, el numero a adivinar es mayor: ");
                    intentos--;
                }
            } while (intentos > 0);
            if (intentos == 0)
            {
                Console.WriteLine("El numero era, " +aleatorio); 
            }
        }
    }
}
