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

            //Debe ser en un "do" ya que al cerrar la aplicación se mueren lo contactos

            do
            {
                Console.WriteLine("Ingrese una opción\nAgregar contacto [1]\nEliminar contacto [2]\nMostrar contacto [3]\nSalir [4]");
                //Estructura de control de excepciones para el manejo de números
                do
                {
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ingresa un número");
                        Console.ReadKey();
                    }
                } while (true);

                //Dependiendo de la elección var a agregar, eliminar o mostrar contactos
                switch (opcion)
                {
                    case 1:
                        //Lee los datos y los guarda en variables
                        Console.WriteLine("Ingrese el nombre del contacto");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el número telefónico");
                        tel = Console.ReadLine();
                        //Guarda el dato en el diccionario con una key y value
                        agendita[nombre] = tel;
                    break;

                    case 2:
                        Console.WriteLine("Ingrese el nombre del contacto a borrar");
                        //Estructura para manejar el error de fuera de indice
                        try
                        {
                            nombre = Console.ReadLine();
                            agendita.Remove(nombre);
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("No existe");
                            break;
                        }
                        

                    case 3:
                        Console.WriteLine("Ingrese el nombre del contacto a mostrar");
                        //Estructura para manejar el error de fuera de indice
                        try
                        {
                            nombre = Console.ReadLine();
                            Console.WriteLine("Nombre: {0} - Teléfono: {1}", nombre, agendita[nombre]);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("No existe");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Adiós :)");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
