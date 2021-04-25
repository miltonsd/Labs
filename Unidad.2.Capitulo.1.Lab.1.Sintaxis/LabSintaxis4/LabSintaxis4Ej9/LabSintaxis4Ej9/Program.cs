using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número de filas que conformará al triángulo: ");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nTriángulo\n");
            int max_asteriscos = filas * 2 - 1;
            for (int i = 0; i < filas; i++)
            {
                int asteriscos = i * 2 + 1;
                int espacios = (max_asteriscos - asteriscos) / 2;
                for (int j = 0; j < espacios; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asteriscos; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < espacios; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Write("\nPulse para salir.");
            Console.ReadKey();
        }
    }
}
