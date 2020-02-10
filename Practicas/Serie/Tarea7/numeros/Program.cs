using System;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números complejos");

            //Crea tres números complejos
            //Uno es la suma de estos dos objetos
            NumeroComplejo nc1 = new NumeroComplejo(4, 5);
            NumeroComplejo nc2 = new NumeroComplejo(1, 9);
            NumeroComplejo nc3 = nc1 + nc2;

            //Muestra el resultado
            nc3.MostrarInformacion();
        }
    }
}
