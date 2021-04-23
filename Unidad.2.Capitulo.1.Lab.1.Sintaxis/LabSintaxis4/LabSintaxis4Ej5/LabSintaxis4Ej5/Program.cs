using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej5
{
    class Program
    {
        static int obtenerMes (string nombreMes)
        {
            switch (nombreMes)
            {
                case "enero":
                    return 1;
                case "febrero":
                    return 2;
                case "marzo":
                    return 3;
                case "abril":
                    return 4;
                case "mayo":
                    return 5;
                case "junio":
                    return 6;
                case "julio":
                    return 7;
                case "agosto":
                    return 8;
                case "septiembre":
                    return 9;
                case "octubre":
                    return 10;
                case "noviembre":
                    return 11;
                case "diciembre":
                    return 12;
                default:
                    Console.WriteLine("\nEl mes no existe. Se cerrará la aplicación");
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Escribe un mes del año: ");
            string nombreMes = Console.ReadLine().ToLower();
            int nroMes = obtenerMes(nombreMes);
            if (nroMes != 0)
            {
                Console.WriteLine("\n"+nombreMes + " + " + nroMes);
            }
            Console.Write("\nPulse para salir.");
            Console.ReadKey();
        }
    }
}
