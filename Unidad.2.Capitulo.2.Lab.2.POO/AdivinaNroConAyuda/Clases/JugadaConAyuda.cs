using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class JugadaConAyuda : Jugada
    {
        private int _numeroMax;

        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {
        }

        public int NumeroMax
        {
            get => _numeroMax;
            set => _numeroMax = value;
        }

        public new void Comparar(int nro)
        {
            Intentos += 1;
            if (nro == Numero)
            {
                Console.WriteLine("Correcto. Adivinaste el número!");
                Adivino = true;
            }
            else
            {
                /*
                 Armar intervaos definidos por el número a adivinar:
                    nrosMayores = cantidad de números mayores que el número a adivinar.
                    nrosMenores = cantidad de números mayores que el número a adivinar.
                    rango = el intervalo con mayor cantidad de números
                 */
                int nrosMayores = NumeroMax - Numero;
                int nrosMenores = Numero;
                int rango = (nrosMayores > nrosMenores) ? nrosMayores : nrosMenores;
                /*
                 Definir el número que alcanzará los intervalos para la ayuda según las reglas:
                    * Muy cerca = 10% del rango cercano a Numero
                    * Cerca = 30% del rango cercano siguiente a Numero
                    * Lejos = 40% del rango cercano siguiente a Numero
                    * Muy lejos = 20% del rango cercano siguiente a Numero (infinito) 
                 */
                int muyCerca = Convert.ToInt32(Math.Ceiling(rango * 0.1));
                int cerca = Convert.ToInt32(Math.Ceiling(rango * 0.3));
                int lejos = Convert.ToInt32(Math.Ceiling(rango * 0.4));
                if (nro > Numero)
                {
                    Console.Write("El número correcto es menor que el ingresado. ");
                    if (nro <= (Numero + muyCerca))
                    {
                        Console.WriteLine("El número está muy cerca del correcto.");
                    }
                    else if ((nro > (Numero + muyCerca)) && (nro <= (Numero + cerca)))
                    {
                        Console.WriteLine("El número está cerca del correcto.");
                    }
                    else if ((nro > (Numero + cerca)) && (nro <= (Numero + lejos)))
                    {
                        Console.WriteLine("El número está lejos del correcto.");
                    }
                    else
                    {
                        Console.WriteLine("El número está muy lejos del correcto.");
                    }
                }
                else
                {
                    Console.Write("El número correcto es mayor que el ingresado. ");
                    if (nro >= (Numero - muyCerca))
                    {
                        Console.WriteLine("El número está muy cerca del correcto.");
                    }
                    else if ((nro < (Numero - muyCerca)) && (nro >= (Numero - cerca)))
                    {
                        Console.WriteLine("El número está cerca del correcto.");
                    }
                    else if ((nro < (Numero - cerca)) && (nro >= (Numero - lejos)))
                    {
                        Console.WriteLine("El número está lejos del correcto.");
                    }
                    else
                    {
                        Console.WriteLine("El número está muy lejos del correcto.");
                    }
                }
            }
        }
    }
}