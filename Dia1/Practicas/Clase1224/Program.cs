using System;

namespace Clase1224
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Armando");
            Console.WriteLine(c1.Nombre);
            Console.WriteLine(c1.Edad = 2222);
            Console.WriteLine(Cliente.msj());
        }
    }
}
