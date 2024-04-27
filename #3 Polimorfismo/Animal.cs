using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Polimorfismo
{
    abstract class Animal
    {
        private string _nombre;
        public Animal(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        public abstract void HacerSonido();
    }

}
