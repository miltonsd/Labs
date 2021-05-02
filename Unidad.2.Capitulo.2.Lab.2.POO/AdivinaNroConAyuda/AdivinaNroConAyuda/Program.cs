using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace AdivinaNroConAyuda
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego jue = new Juego();
            jue.ComenzarJuego();
            Console.ReadKey();
        }
    }
}
