using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Construya un programa que permita leer una cantidad
             * de 20 números y nos indique finalmente cuantos fueron positivos, 
             * cuantos fueron negativos y cuantas veces se introdujo el cero.*/

            int cont = 0, numUsuario, contPositivos = 0,contCeros = 0, contNegativos = 0;

            while (cont < 20)
            {
                Console.WriteLine("Ingrese el numero #" + (cont + 1) + " que desee, se permiten negativos y positivos :)");
                numUsuario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (numUsuario < 0)
                {
                    contNegativos = contNegativos + 1;
                }
                else if (numUsuario > 0)
                {
                    contPositivos = contPositivos + 1 ;
                }
                else
                {
                    contCeros = contCeros + 1;
                }

                cont = cont + 1
                    ;
            }
            Console.WriteLine($"Numeros Positivos: {contPositivos} \nNumeros Negativos: {contNegativos} \nCeros ingresados: {contCeros}" );
            Console.ReadKey();
        }
    }
}
