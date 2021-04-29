using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Clases
{
    public class B : A
    {
        public B() : base("Instancia de B")
        {
        }
        public void M4()
        {
            WriteLine("Método del hijo Invocado");
        }
    }
}
