using System;
using System.Collections.Generic;

namespace agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            string tel;
            int opcion;
            Console.WriteLine("Agenda telefónica");
            Dictionary<string, string> agendita = new Dictionary<string, string>();

            do
            {
                Console.WriteLine("Ingrese una opción\nAgregar contacto [1]\nEliminar contacto [2]\nMostrar contacto [3]\nSalir [4]");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del contacto");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el número telefónico");
                        tel = Console.ReadLine();
                        agendita[nombre] = tel;
                    break;

                    case 2:
                        Console.WriteLine("Ingrese el nombre del contacto a borrar");
                        nombre = Console.ReadLine();
                        agendita.Remove(nombre);
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el nombre del contacto a mostrar");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Nombre: {0} - Teléfono: {1}", nombre , agendita[nombre]);
                        break;
                    default:
                        Console.WriteLine("Adiós :)");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
