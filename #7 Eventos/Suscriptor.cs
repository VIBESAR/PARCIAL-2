using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Eventos
{
    class Suscriptor
    {
        public Suscriptor(Contador contador)
        {
            contador.ValorCambiado += OnValorCambiado;
        }
        private void OnValorCambiado(object sender, EventArgs e)
        {
            Contador contador = (Contador)sender;
            Console.WriteLine("Valor del contador cambiado a: " + contador.Valor);
        }
    }

}
