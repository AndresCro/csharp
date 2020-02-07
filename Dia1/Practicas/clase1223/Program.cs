using System;

namespace clase1223{
    class Program{


        static void Main(string[] args)
        {
            Persona p1 = new Persona("Carlos", 21);
            Persona p2 = new Persona("Carlos", 21);

            Console.WriteLine("Comparacion de memoria");
            Console.WriteLine(p1 == p2);
            Console.WriteLine("Comparacion de objetos");
            Console.WriteLine(p1.Equals(p2));

            Console.ReadKey(true);
        }
    }
}
