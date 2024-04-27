using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Herencia
{
    class Gerente : Empleado
    {
        private double _bono;

        public Gerente(string nombre, int salarioBase, double bono) : base(nombre, salarioBase)
        {
            _bono = bono;
        }

        public override double CalcularSalarioBruto()
        {
            return base.CalcularSalarioBruto() + _bono; 
        }
    }

}
