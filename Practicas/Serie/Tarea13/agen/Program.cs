using System;

namespace agencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agencia");

            CarroBWM c1 = new CarroBWM(100000, 1.90);
            CarroVW c2 = new CarroVW(50000, 1.70);

            Console.WriteLine("BMW\n");

            c1.Apagar();
            c1.Encender();
            c1.Estado();
            Console.WriteLine(c1.ToString());

            Console.WriteLine("\nVW\n");

            c2.Apagar();
            c2.Encender();
            c2.Estado();
            Console.WriteLine(c2.ToString());
        }
    }
}
