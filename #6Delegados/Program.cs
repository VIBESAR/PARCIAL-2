using _6.Delegados;
using System;

namespace EjemploDelegados
{
    class Program
    { 
        public delegate int DelegadoOperacion(int x); 
        static int Sumar(int x)
        {
            return x + 10;
        }

        static int Multiplicar(int x)
        {
            return x * 2;
        }

        static int ProcesarTemperatura(int nuevaTemperatura) 
        {
            int temperaturaProcesada = nuevaTemperatura * 2;
            Console.WriteLine("Temperatura procesada: " + temperaturaProcesada);
            return temperaturaProcesada;
        }

        static void Main(string[] args)
        {
            
            DelegadoOperacion miDelegado = Sumar; 
            int resultado = miDelegado(5);
            Console.WriteLine("Resultado de la Suma: " + resultado);
            Sensor sensor = new Sensor();
            sensor.TemperaturaCambiada += ProcesarTemperatura;
            sensor.CambiarTemperatura(30);
            Console.ReadLine();
        }
    }
}







