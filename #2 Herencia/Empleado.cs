using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Herencia
{
    class Empleado
    {
        private string _nombre;
        private int _salarioBase;
        public Empleado(string nombre, int salarioBase)
        {
            _nombre = nombre;
            _salarioBase = salarioBase;
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        
        public virtual double CalcularSalarioBruto()
        {
            return _salarioBase;
        }

        public double CalcularImpuestoRenta()
        {
            return CalcularSalarioBruto() * 0.1;
        }

        public double CalcularSalarioNeto()
        {
            return CalcularSalarioBruto() - CalcularImpuestoRenta();
        }
    }

}
