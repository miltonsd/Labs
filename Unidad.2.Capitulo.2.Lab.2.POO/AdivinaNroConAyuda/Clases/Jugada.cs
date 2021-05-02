using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Adivino = false;
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public bool Adivino
        {
            get => _adivino;
            set => _adivino = value;
        }

        public int Intentos
        {
            get => _intentos;
            set => _intentos = value;
        }

        public int Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public void Comparar(int nro)
        {
            Intentos += 1;
            if (nro == Numero)
            {
                Console.WriteLine("Correcto. Adivinaste el número!");
                Adivino = true;
            }
            else
            {
                Console.WriteLine("Incorrecto! Intenta de nuevo.");
            }
        }
    }
}
