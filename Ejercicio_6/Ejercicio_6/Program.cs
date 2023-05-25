using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leer 10 números e indicar cuánto es la suma de todos ellos*/
           
            int total = 0;

            Console.WriteLine("Ingrese 10 números:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                int numero = Convert.ToInt32(Console.ReadLine());

                total += numero;
            }

            Console.WriteLine("\nLa suma de los 10 números es: "+ total);
            Console.ReadKey();
        }
    }
 }

