using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8.Leer una cantidad variable de números e indicar cuánto suman todos los números, y cuál es el promedio de los números*/

            int cantidadNumeros = 0, suma = 0, promedio, numeros;

            Console.WriteLine( "Ingrese la cantidad de numeros que desea ingresar");
            cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine("Ingrese los numeros !! #" + (i + 1));
                numeros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                suma = suma + numeros;
            }

            promedio = suma + cantidadNumeros;

            Console.WriteLine("El promedio de los numeros es de: " + promedio);
        }
    }
}
