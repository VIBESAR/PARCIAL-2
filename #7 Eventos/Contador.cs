using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Eventos
{
    class Contador
    {
        private int valorActual;

        public event EventHandler ValorCambiado;
        public int Valor
        {
            get { return valorActual; }
            set
            {
                if (valorActual != value)
                {
                    valorActual = value;
                    OnValorCambiado(EventArgs.Empty);
                }
            }
        }
        private void OnValorCambiado(EventArgs e)
        {
            ValorCambiado?.Invoke(this, e);
        }
    }

}
