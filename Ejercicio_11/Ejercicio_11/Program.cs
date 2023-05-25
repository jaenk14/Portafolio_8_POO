using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11.	Construya un programa que permita leer sólo números positivos hasta reunir 10 números pares,
             * o el número 5 cuatro veces. Al final debe indicar la totalidad de números leídos.*/

            bool terminaPrograma = false;

            int num, contNumPares = 0, contNumCinco = 0, cont = 0;

            while (!terminaPrograma)
            {
                Console.WriteLine("Ingrese el numero que desee");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                {
                    cont++;

                    if (num % 2 == 0)
                    {
                        contNumPares = contNumPares + 1;
                    }
                    else if (num == 5)
                    {
                        contNumCinco = contNumCinco + 1;
                    }

                    if (contNumPares == 10)
                    {
                        terminaPrograma = true;
                    }
                    else if (contNumCinco == 5)
                    {
                        terminaPrograma = true;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido!!!!");
                }
            }

            Console.WriteLine("\nLa cantidad de numeros leidos fueron: " + cont);
            Console.ReadKey();
        }
    }
}
