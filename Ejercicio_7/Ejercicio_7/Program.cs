using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7.Leer 10 números e indicar cuánto suman los números pares.*/

            int totalPares = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el número" + (i + 1) + ": ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    totalPares += numero;
                }
            }

            Console.WriteLine("\nLa suma de los números pares es: " + totalPares);
            Console.ReadKey();
        }
    }
}
