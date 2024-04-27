using System;

interface IReproducible
{
    void Reproducir();
    void Pausar();
    void Detener();
}

class ReproductorMP3 : IReproducible
{
    public void Reproducir()
    {
        Console.WriteLine("Reproduciendo MP3 ♪");
    }
    public void Pausar()
    {
        Console.WriteLine("Pausando reproducción de MP3 ⏸️");
    }
    public void Detener()
    {
        Console.WriteLine("Deteniendo reproducción de MP3 ⏹️");
    }
}


class ReproductorVideo : IReproducible
{
    public void Reproducir()
    {
        Console.WriteLine("Reproduciendo video ▶️");
    }

    public void Pausar()
    {
        Console.WriteLine("Pausando reproducción de video ⏸️");
    }

    public void Detener()
    {
        Console.WriteLine("Deteniendo reproducción de video ⏹️");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        IReproducible reproductorMP3 = new ReproductorMP3();
        IReproducible reproductorVideo = new ReproductorVideo();
      
        reproductorMP3.Reproducir();
        reproductorMP3.Pausar();
        reproductorMP3.Detener();

        reproductorVideo.Reproducir();
        reproductorVideo.Pausar();
        reproductorVideo.Detener();
    }
}


