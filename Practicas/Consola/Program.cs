using System;
using System.IO;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una lista que guardará los comandos
            List<string> historial = new List<string>();
            //Crea un array en donde se va a guardar el comando con las opciones
            string[] parametros;

            //Iniciamos el prompt en Documentos
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            //Guardamos el prompt en una variable para posterior mostrarla
            string path = Directory.GetCurrentDirectory();

            //Un ciclo infinito
            do
            {
                Console.Write(path + " ");

                //Lee el comando
                string comando = Console.ReadLine();
                historial.Add(comando);
                //Divido el comando en sus opciones
                parametros = comando.Split(" ");
                string argumento;
                //Si es un 1 la opción es "."
                if (parametros.Length == 1)
                {
                    argumento = ".";
                }
                else
                {
                    argumento = parametros[1];
                }
                //Para los comandos touch y move se necesitan dos argumentos, así que no los tienen manda un aviso
                //Si es diferente de los comandos actuales manda un aviso.
                try
                {
                    switch (parametros[0])
                    {
                        case "dir":
                            listar(argumento);
                            break;
                        case "cd":
                            path = cambiar(argumento);
                            break;
                        case "touch":
                            crear(parametros[1]);
                            break;
                        case "move":
                            mover(parametros[1], parametros[2]);
                            break;
                        case "history":
                            foreach (var a in historial)
                            {
                                Console.WriteLine(a);
                            }
                            break;
                        default:
                            Console.WriteLine("Comandos funcionales -> cd, dir, touch, move, history");
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ingresa las rutas rutas correctas");
                }
            } while (true);
        }

        public static void listar(string argumento)
        {
            //Manejo de excepciones en directorio no encotrado y acceso no autorizado
            try
            {
                //Obtiene los archivos y directorios
                DirectoryInfo di = new DirectoryInfo(argumento);
                foreach (var fi in di.GetFiles())
                {
                    Console.WriteLine(fi.Name);
                }
                foreach (var fi in di.GetDirectories())
                {
                    Console.WriteLine(fi.Name);
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Ruta no valida");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ruta no valida");
            }
        }

        public static string cambiar(string argumento)
        {
            //Manejo de excepciones en directorio no encotrado y acceso no autorizado
            try
            {
                //Cambia el directorio actual
                Environment.CurrentDirectory = (argumento);
                return Directory.GetCurrentDirectory();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Ruta no valida");
                return Directory.GetCurrentDirectory();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ruta no valida");
                return Directory.GetCurrentDirectory();
            }
        }

        public static void crear(string argumento)
        {
            //Manejo de excepciones en directorio no encotrado y acceso no autorizado
            try
            {
                //Crea un archivo con Hola mundo :)
                StreamWriter f1;
                f1 = File.CreateText(argumento);
                f1.Write("Hola mundo :)");
                f1.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ruta no valida");
            }
        }
        public static void mover(string argumento, string argumento2)
        {
            //Manejo de excepciones en directorio no encotrado y acceso no autorizado
            try
            {
                //Mueve un archivo de una lado a otro
                File.Move(argumento, argumento2);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Ruta no valida");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ruta no valida");
            }
        }
    }
}
