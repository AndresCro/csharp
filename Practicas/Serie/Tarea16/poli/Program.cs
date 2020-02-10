using System;

namespace poli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polimorfismo");

            //Llamo a la misma clase pero con dos diferentes instancias
            Persona p1 = new Persona("Carlos",25);
            Persona p2 = new Empleado("Andrés", 20, 50000);

            //Muestro los datos
            p1.Datos();
            p2.Datos();
        }
    }
}
