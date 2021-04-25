using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el número máximo en donde se buscarán primos gemelos: ");
            int nro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 2; i < nro; i++)
            {
                bool esPrimo = true;
                // Búsqueda del primer número primo
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    // Evaluar si segundo número es primo
                    for (int j = 2; j < (i + 2); j++)
                    {
                        if ((i + 2) % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                    if (esPrimo)
                    {
                        Console.WriteLine("Los números "+i+" y "+(i+2)+" son primos gemelos.");
                    }
                }
            }
            Console.Write("\nPulse para salir.");
            Console.ReadKey();
        }
    }
}
