using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, resultado;
            Console.Write("Ingrese el primer número: ");
            nro1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            nro2 = Convert.ToInt32(Console.ReadLine());
            resultado = nro1 + nro2;
            Console.WriteLine("\nEl resultado de la suma de "+nro1+" y "+nro2+" es "+resultado);
            Console.Write("Pulsa para salir.");
            Console.ReadKey();
        }
    }
}
