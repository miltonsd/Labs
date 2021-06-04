using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Circulo
    {
        private double m_radio;

        public double Radio
        {
            get { return m_radio; }
            set { m_radio = value; }
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
