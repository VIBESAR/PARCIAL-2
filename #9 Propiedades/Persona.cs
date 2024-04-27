using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Propiedades
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string ciudad;

        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        
        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

       
        public void ImprimirInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Ciudad: " + Ciudad);
        }
    }

}
