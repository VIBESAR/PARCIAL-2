using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Delegados
{
    class Sensor
    {
        public event DelegadoOperacion TemperaturaCambiada;

        public void CambiarTemperatura(int nuevaTemperatura)
        {
            
            Console.WriteLine("Temperatura anterior: " + temperaturaActual);
            temperaturaActual = nuevaTemperatura;
            if (TemperaturaCambiada != null)
            {
                TemperaturaCambiada(nuevaTemperatura);
            }
        }
        private int temperaturaActual;
    }

}
