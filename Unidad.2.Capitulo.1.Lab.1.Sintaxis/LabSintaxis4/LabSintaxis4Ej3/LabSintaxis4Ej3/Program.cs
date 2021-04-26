using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números a mostrar: ");
            int nros = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[nros];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < nros; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }
            Console.WriteLine("\nLos primeros " + nros + " numeros de la serie de fibonacci son:");
            for (int i = 0; i < nros; i++)
            {
                Console.WriteLine(fibonacci[i]);
            }
            Console.Write("\nPulse para salir.");
            Console.ReadKey();
        }
    }
}
