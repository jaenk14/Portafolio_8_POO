using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10.	Leer las edades de los asistentes a un cine e 
             * indicar finalmente cuántos de estos fueron: niños (1-10), adolescentes (11-15), 
             * jóvenes (16-22), adultos (23-65), adultos mayores (más de 65), preguntar si desea leer otro asistente.*/

            int niños = 0;
            int adolescentes = 0;
            int jóvenes = 0;
            int adultos = 0;
            int adultosMayores = 0;

            char respuesta = 'S';

            while (respuesta == 'S')
            {
                Console.WriteLine("Ingrese la edad del asistente:");
                int edad = Convert.ToInt32(Console.ReadLine());


                if (edad >= 1 && edad <= 10)
                {
                    niños++;
                }
                else if (edad >= 11 && edad <= 15)
                {
                    adolescentes++;
                }
                else if (edad >= 16 && edad <= 22)
                {
                    jóvenes++;
                }
                else if (edad >= 23 && edad <= 65)
                {
                    adultos++;
                }
                else if (edad > 65)
                {
                    adultosMayores++;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Intente nuevamente.");
                }
                Console.WriteLine("\nDeseas ingresar otro asistente? \n" +
                    "SI = S o NO = N");
                respuesta = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.WriteLine();
            }

            Console.WriteLine("Resultados:");
            Console.WriteLine("Niños (1-10): " + niños);
            Console.WriteLine("Adolescentes (11-15): " + adolescentes);
            Console.WriteLine("Jóvenes (16-22): " + jóvenes);
            Console.WriteLine("Adultos (23-65): " + adultos);
            Console.WriteLine("Adultos mayores (más de 65): " + adultosMayores);

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
