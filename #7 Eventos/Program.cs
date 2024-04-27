using _7.Eventos;

class Program
{
    static void Main(string[] args)
    {
        Contador contador = new Contador();
        Suscriptor suscriptor = new Suscriptor(contador);
        contador.Valor = 10; 
        contador.Valor = 15; 
        Console.ReadLine();
    }
}

