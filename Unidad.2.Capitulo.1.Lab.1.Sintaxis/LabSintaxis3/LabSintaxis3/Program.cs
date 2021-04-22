using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arreglo = new string[cantIteraciones];
            Console.WriteLine("Ingrese texto.");
            for (int i = 0; i < cantIteraciones; i++)
            {
                arreglo[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Texto ingresado:");
            for (int i = cantIteraciones-1; i >= 0; i--)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Pulse para salir.");
            Console.ReadKey();
        }
    }
}
