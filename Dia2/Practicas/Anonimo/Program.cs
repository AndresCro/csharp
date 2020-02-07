using System;

namespace Anonimo
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonimo = new
            {
                Modelo = "Bocho",
                Precio = 80000,
                Placas = "45TRH9"
            };
            Console.WriteLine("Datos anónimos");
            Console.WriteLine(anonimo.Modelo);
            Console.WriteLine(anonimo.Precio);
            Console.WriteLine(anonimo.Placas);
        }
    }
}
