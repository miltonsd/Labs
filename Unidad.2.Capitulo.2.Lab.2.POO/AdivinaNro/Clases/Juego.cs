using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Juego
    {
        private int _record;

        public Juego()
        {
            Record = 0;
        }

        public int Record
        {
            get
            {
                return _record;
            }
            set
            {
                _record = value;
            }
        }

        public void ComenzarJuego()
        {
            int nroMax = this.PreguntarMaximo();
            Jugada jug = new Jugada(nroMax);
            while (!jug.Adivino)
            {
                int nro = this.PreguntarNumero();
                jug.Comparar(nro);
            }
            this.CompararRecord(jug.Intentos);
            this.Continuar();
        }

        private int PreguntarMaximo()
        {
            Console.Write("Ingrese el número máximo del rango a adivinar: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private int PreguntarNumero()
        {
            Console.Write("Ingrese el número que cree que es el correcto: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private void CompararRecord(int intentos)
        {
            if ((intentos < Record) || (Record == 0))
            {
                Console.WriteLine("Nuevo Record!!. El número fue adivinado en " + intentos + " intentos");
                Record = intentos;
            }
        }

        private void Continuar()
        {
            Console.Write("\n¿Desea jugar de nuevo? (S/N) ");
            ConsoleKeyInfo opcion;
            do
            {
                opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("\n");
                        this.ComenzarJuego();
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("\n\nPulse para salir. Muchas gracias por jugar!");
                        break;
                    default:
                        Console.Write("\n\nIngrese una opción válida (S/N) ");
                        break;
                }
            } while ((opcion.Key != ConsoleKey.S) && (opcion.Key != ConsoleKey.N));
        }
    }
}
