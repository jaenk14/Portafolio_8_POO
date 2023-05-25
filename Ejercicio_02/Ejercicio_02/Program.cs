using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Construya un programa que permita leer una cantidad variable de números
             * y nos indique cuantos fueron mayores o iguales a 100 y cuántos menores a 100,
             * cada vez que ingresa un número debe preguntar si desea ingresar otro.*/

            char respuesta = 'S';
            int contMayoresOigual = 0, contMenores = 0,numero;

            while (respuesta == 'S')
            {
                Console.WriteLine("\nIngrese el numero");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 100)
                {
                    contMayoresOigual = contMayoresOigual + 1;
                }
                else
                {
                    contMenores = contMenores + 1;
                }
                Console.WriteLine("\nDesea ingresar otro numero?");
                respuesta = Convert.ToChar(Console.ReadLine().ToUpper());
            }

            Console.WriteLine($"\nLa cantidad de numeros mayores o iguales a 100: {contMayoresOigual}\nLa cantidad de numeros menores a 100: {contMenores}");
            Console.ReadKey();
        }
    }
}
