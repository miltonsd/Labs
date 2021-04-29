using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Clases
{
    public class A
    {
        //public string NombreInstancia;
        //protected string NombreInstancia;
        private string _NombreInstancia;
        public A()
        {
            //NombreInstancia = "Instancia sin nombre";
            _NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            //NombreInstancia = nombre;
            _NombreInstancia = nombre;
        }
        public void MostrarNombre()
        {
            //WriteLine(NombreInstancia);
            WriteLine(_NombreInstancia);
        }
        public void M1()
        {
            WriteLine("El método M1 fue invocado.");
        }
        public void M2()
        {
            WriteLine("El método M2 fue invocado.");
        }
        public void M3()
        {
            WriteLine("El método M3 fue invocado.");
        }
    }
}
