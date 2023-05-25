using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9.	Leer una cantidad de números variables hasta que se ingrese un número múltiplo de 5.
             * Indicar el número de datos que fueron ingresados, sin contar el múltiplo
             * de la condición de término.*/

            int contador = 1, cantidadNumeros = 0, numero = 0;
            bool multiplo = false;
            Console.WriteLine("Cuantos numeros deseas ingresar? ");
            cantidadNumeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (!multiplo)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (numero % 5 == 0)
                {
                    multiplo = true;
                    contador = --contador;
                }
                else if (contador == cantidadNumeros)
                {
                    multiplo = true;
                }
                else
                {
                    contador = contador + 1;    
                }
                
            }

            Console.WriteLine("\nLa cantidad de numeros ingresados son: " + contador);
            Console.ReadKey();
        }
    }
}
