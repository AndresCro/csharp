using System;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personas");

            //Crea una persona
            Persona p1 = new Persona("Carlos", 30, 1.80, 70);

            //Muestra lo que puede hacer
            p1.DibujarCuadro();
            p1.Informacion();
            p1.Imc();
        }
    }
}
