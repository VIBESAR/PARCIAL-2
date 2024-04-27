using System;
using _8.Indexadores;

namespace _8.Indexadores
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaPalabras listaPalabras = new ListaPalabras();

            listaPalabras[0] = "Hola";
            string palabra1 = listaPalabras[0];
            Console.WriteLine("Palabra en índice 0: " + palabra1);

            try
            {
                listaPalabras[10] = "Mundo"; // This will trigger the error
                Console.WriteLine("Palabra en índice 10: " + listaPalabras[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            listaPalabras["Mundo"] = "Adiós";
            string palabra2 = listaPalabras["Mundo"];
            Console.WriteLine("Palabra 'Mundo': " + palabra2);

            string palabra3 = listaPalabras["NoExiste"];
            if (palabra3 != null)
            {
                Console.WriteLine("Palabra 'NoExiste': " + palabra3);
            }
            else
            {
                Console.WriteLine("La palabra 'NoExiste' no se encuentra en la lista");
            }
        }
    }
}
