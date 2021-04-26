using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero entre 1 y 3999: ");
            int nro = Convert.ToInt32(Console.ReadLine());
            if ((nro >= 1) && (nro <= 3999))
            {
                string nroRomano = "";
                // Dividido 1000
                int cantLetras = nro / 1000;
                nro -= cantLetras * 1000;
                for (int i = 0; i < cantLetras; i++)
                {
                    nroRomano += "M";
                }
                // Dividido 100
                cantLetras = nro / 100;
                nro -= cantLetras * 100;
                switch (cantLetras)
                {
                    case 9:
                        nroRomano += "CM";
                        break;
                    case 8:
                    case 7:
                    case 6:
                    case 5:
                        nroRomano += "D";
                        for (int i = 0; i < cantLetras - 5; i++)
                        {
                            nroRomano += "C";
                        }
                        break;
                    case 4:
                        nroRomano += "CD";
                        break;
                    case 3:
                    case 2:
                    case 1:
                        for (int i = 0; i < cantLetras; i++)
                        {
                            nroRomano += "C";
                        }
                        break;
                    default:
                        break;
                }
                // Dividido 10
                cantLetras = nro / 10;
                nro -= cantLetras * 10;
                switch (cantLetras)
                {
                    case 9:
                        nroRomano += "XC";
                        break;
                    case 8:
                    case 7:
                    case 6:
                    case 5:
                        nroRomano += "L";
                        for (int i = 0; i < cantLetras - 5; i++)
                        {
                            nroRomano += "X";
                        }
                        break;
                    case 4:
                        nroRomano += "XL";
                        break;
                    case 3:
                    case 2:
                    case 1:
                        for (int i = 0; i < cantLetras; i++)
                        {
                            nroRomano += "X";
                        }
                        break;
                    default:
                        break;
                }
                // Unidades
                switch (nro)
                {
                    case 9:
                        nroRomano += "IX";
                        break;
                    case 8:
                    case 7:
                    case 6:
                    case 5:
                        nroRomano += "V";
                        for (int i = 0; i < nro - 5; i++)
                        {
                            nroRomano += "I";
                        }
                        break;
                    case 4:
                        nroRomano += "IV";
                        break;
                    case 3:
                    case 2:
                    case 1:
                        for (int i = 0; i < nro; i++)
                        {
                            nroRomano += "I";
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nEl número en símbolos romanos es: "+nroRomano);
            } else
            {
                Console.WriteLine("\nEl número ingresado no se encuentra en los intervalos [1-3999]. Se cerrará la aplicación.");
            }
            Console.Write("\nPulse para salir.");
            Console.ReadKey();
        }
    }
}
