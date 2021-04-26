using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese un texto.");
            string inputTexto = Console.ReadLine();
            Console.WriteLine();
            if (string.IsNullOrEmpty(inputTexto))
            {
                Console.WriteLine("Mensaje no ingresado. La aplicación se cerrará.");
            } else
            {
                Console.WriteLine("MENÚ DE OPCIONES");
                Console.WriteLine("1.   Mostrar la frase ingresada en MAYÚSCULAS");
                Console.WriteLine("2.   Mostrar la frase ingresada en minúsculas");
                Console.WriteLine("3.   Mostrar la cantidad de caracteres que posee el texto");
                Console.Write("Ingresar la opcion deseada: ");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine(inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("El texto contiene "+inputTexto.Length+" caracteres");
                }
                else
                {
                    Console.WriteLine("Opción incorrecta. El programa se cerrará.");
                }
            }
            Console.WriteLine("Pulsa para salir.");
            Console.ReadKey();
        }
    }
}
