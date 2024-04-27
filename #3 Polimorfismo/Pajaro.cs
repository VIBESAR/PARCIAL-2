using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Polimorfismo
{
    class Pajaro : Animal
    {
        public Pajaro(string nombre) : base(nombre) { }
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Chirp-Chirp!");
        }
    }

}
