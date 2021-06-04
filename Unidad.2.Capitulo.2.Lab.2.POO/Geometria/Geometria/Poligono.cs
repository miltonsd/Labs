using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Poligono
    {
        public virtual double CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public virtual double CalcularSuperficie()
        {
            throw new System.NotImplementedException();
        }
    }

    class Rectangulo : Poligono
    {
        private double m_lado1;
        private double m_lado2;

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

        public override double CalcularPerimetro()
        {
            return Lado1 * 2 + Lado2 * 2;
        }

        public override double CalcularSuperficie()
        {
            return Lado1 * Lado2;
        }
    }

    class Cuadrado : Rectangulo
    {
        public override double CalcularPerimetro()
        {
            return 4 * Lado1;
        }

        public override double CalcularSuperficie()
        {
            return Math.Pow(Lado1, 2);
        }
    }
}