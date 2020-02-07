using System;

namespace clasesabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales =
            {
                new Carnivoro("Leon"),
                new Herbivoro("Jirafa")
            };

            Console.WriteLine("Lista de animales");

            foreach (Animal ani in animales)
            {
                Console.WriteLine(ani);
            }

            Lobo lobo = new Lobo("Lobezno");
            lobo.Cazar();
            Console.WriteLine(":)");
            (lobo as Carnivoro).Cazar();

            Pinguinno pun = new Pinguinno("Pingu");
            pun.Cazar();

        }
    }
}
