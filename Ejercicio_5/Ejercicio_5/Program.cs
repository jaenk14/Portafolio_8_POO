using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0,numero;
           

            Console.WriteLine("Ingrese números. Ingrese cinco números negativos para terminar. \n");

            while (contador < 5)
            {
                Console.Write("Ingrese un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    contador++;
                }
            }

            Console.WriteLine("\n Se ingresaron 5 números negativos.");
            Console.WriteLine("Cantidad total de números leídos: " + contador);
            Console.ReadKey();
        }
    }
}
