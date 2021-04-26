using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            while (intentos < 4)
            {
                intentos = intentos + 1;
                Console.Write("Introduzca clave: ");
                string inputClave = Console.ReadLine();
                if (inputClave == "Clave")
                {
                    Console.WriteLine("\nClave correcta!");
                    break;
                }
                else
                {
                    Console.Write("\nClave Incorrecta!! ");
                }
            }
            Console.Write("\nFin de la aplicación. Pulse para salir.");
            Console.ReadLine();
        }
    }
}
