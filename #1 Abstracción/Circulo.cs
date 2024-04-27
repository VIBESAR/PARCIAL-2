using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Abstracción
{
    
    class Circulo : Figura
    {
        private double _radio;

        
        public Circulo(double radio)
        {
            _radio = radio;
        }

        
        public override double CalcularArea()
        {
            return Math.PI * _radio * _radio;
        }

        
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * _radio;
        }
    }

}
