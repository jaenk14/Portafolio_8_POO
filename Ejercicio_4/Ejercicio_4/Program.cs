using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros, contNumerosPares = 0, contNumerosImpares = 0, contNumeroMultiplosTres = 0;

            Console.WriteLine("Cuantos numeros desea ingresar?");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine("\nIngrese el numero " + (i + 1) + "");
                numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros % 2 == 0)
                {
                    contNumerosPares++;
                }
                else
                {
                    contNumerosImpares++;
                }

                 if (numeros % 3 == 0)
                {
                    contNumeroMultiplosTres++;
                }
            }
            Console.WriteLine("\nCantidad numeros pares: " + contNumerosPares + "\n" +
                "Cantidad numeros multiplos de 3: " + contNumeroMultiplosTres + "\n" +
                "Cantidad numero impares: " + contNumerosImpares);
            Console.ReadLine();
        }
    }
}
