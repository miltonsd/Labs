using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Triangulo
    {
        private double m_lado1;
        private double m_lado2;
        private double m_lado3;

        public double Lado1
        {
            get { return m_lado1; }
            set { m_lado1 = value; }
        }

        public double Lado2
        {
            get { return m_lado2; }
            set { m_lado2 = value; }
        }

        public double Lado3
        {
            get { return m_lado3; }
            set { m_lado3 = value; }
        }

        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public double CalcularSuperficie()
        {
            double s = 0.5 * CalcularPerimetro();
            return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
        }
    }
}
