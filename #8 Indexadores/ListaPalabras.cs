using System;
using System.Collections.Generic;

namespace _8.Indexadores
{
    class ListaPalabras
    {
        private List<string> palabras = new List<string>();

        public string this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < palabras.Count)
                {
                    return palabras[indice];
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice fuera de rango");
                }
            }
            set
            {
                if (indice >= 0 && indice < palabras.Count)
                {
                    palabras[indice] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice fuera de rango");
                }
            }
        }

        public string this[string nombrePalabra]
        {
            get
            {
                int indice = palabras.IndexOf(nombrePalabra);
                if (indice >= 0)
                {
                    return palabras[indice];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                int indice = palabras.IndexOf(nombrePalabra);
                if (indice >= 0)
                {
                    palabras[indice] = value;
                }
                else
                {
                    palabras.Add(value);
                }
            }
        }
    }
}
