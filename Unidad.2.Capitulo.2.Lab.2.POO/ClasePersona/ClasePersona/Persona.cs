using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersona
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private string _dni;

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            DNI = dni;
            Console.WriteLine("Instancia de la clase Persona creada.");
        }

        ~Persona()
        {
            Console.WriteLine("Instancia destruida.");
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string GetFullName()
        {
            return Nombre + " " + Apellido;
        }

        public int GetAge()
        {
            TimeSpan diferenciaFecha = DateTime.Today - FechaNacimiento;
            return diferenciaFecha.Days / 365;
        }
    }
}
