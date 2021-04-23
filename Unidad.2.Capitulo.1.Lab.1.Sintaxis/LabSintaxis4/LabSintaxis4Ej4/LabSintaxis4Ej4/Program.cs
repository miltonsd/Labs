using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de números pares entre el 1 y el 100:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write("\nPulse para salir.");
            Console.ReadKey();
        }
    }
}
