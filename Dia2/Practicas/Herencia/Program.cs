using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Carlos", 22);
            p.Saludar();
            Console.WriteLine(p, ToString());

            Emmpleado e = new Empleado("Luis", 10);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e.ToString());

            Persona p1 = new Persona("Juan", 112);

            Persona[] gente = new Persona[4];

            gente[0] = p;
            gente[1] = p1;
            gente[2] = e;

            Console.WriteLine("Lista de empleados");

            foreach( var per in gente)
            {
                if (per is Empleado)
                    Console.WriteLine(per.ToString());
            }
        }
    }
}
