using _3.Polimorfismo;

Animal[] mascotas = new Animal[]
{
    new Perro("Peluche"),
    new Gato("Copito"),
    new Pajaro("Luna")
};

foreach (Animal animal in mascotas)
{
    animal.HacerSonido();
}

