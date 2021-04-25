using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int anio = Convert.ToInt32(Console.ReadLine());
            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        Console.WriteLine("\nEl año " + anio + " es bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine("\nEl año " + anio + " no es bisiesto.");
                    }
                }
                else
                {
                    Console.WriteLine("\nEl año " + anio + " es bisiesto.");
                }  
            }
            else
            {
                Console.WriteLine("\nEl año " + anio + " no es bisiesto.");
            }
            Console.Write("\nPulse para salir.");
            Console.ReadKey();
        }
    }
}
