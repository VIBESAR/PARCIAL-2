using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Herencia
{  
    class Vendedor : Empleado
    {
        private double _comisionVentas;
        
        public Vendedor(string nombre, int salarioBase, double comisionVentas) : base(nombre, salarioBase)
        {
            _comisionVentas = comisionVentas;
        }

        public override double CalcularSalarioBruto()
        {
            return base.CalcularSalarioBruto() + _comisionVentas; 
        }
    }

}
