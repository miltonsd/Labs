using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasePersona;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pers = new Persona("Juan", "Pérez", Convert.ToDateTime("28/10/1996"), "39948611");
            Console.WriteLine("Nombre completo: " + pers.GetFullName());
            Console.WriteLine("Edad: " + pers.GetAge() + " años.");
            Console.ReadKey();
        }
    }
}
