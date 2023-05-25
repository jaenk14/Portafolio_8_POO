using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNotas = 10;
            int notasAprobadas = 0;
            int notasReprobadas = 0;

            for (int i = 0; i < totalNotas; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                int nota = Convert.ToInt32(Console.ReadLine());

                if (nota >= 70)
                {
                    notasAprobadas++;
                }
                else
                {
                    notasReprobadas++;
                }
            }

            Console.WriteLine("\nAlumnos aprobados: " + notasAprobadas);
            Console.WriteLine("Alumnos reprobados: " + notasReprobadas);

            Console.ReadLine();
        }
    }
}
