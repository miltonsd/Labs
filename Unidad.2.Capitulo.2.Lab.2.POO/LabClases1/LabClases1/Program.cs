using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A claseA1 = new A();
            A claseA2 = new A("Instancia con nombre");
            B claseB = new B();
            claseA1.MostrarNombre();
            claseA1.M1();
            claseA1.M2();
            claseA1.M3();
            claseA2.MostrarNombre();
            claseA2.M1();
            claseA2.M2();
            claseA2.M3();
            claseB.MostrarNombre();
            claseB.M1();
            claseB.M2();
            claseB.M3();
            claseB.M4();
            Console.ReadKey();
        }
    }
}
