using System;
using System.IO;

/*Manejo de archivos
 * Consiste en la manipulación de archivos (sin importar el tipo ya que va a leer bit por bit todo lo que contiene) mediante el uso
 * de System.IO, en el cual creo un objeto de tipo Stream* para determinar la manipulación, en este caso será por flujo de escritura (puede ser lectura)
 * Una vez creado, no se va a modificar nada hasta que se cierre.
 * Si va a escribir, lo que va a pasar es que se elimina todo el contenido y se vuelve a escribir, paro esto hay soluciones como guardarlo
 * en buffer temporal todo el contenido y agregar al buffer lo que es necesario.
 * Close() para guardar y cerrar el objeto.
 * Con File permite la manipulación de archivos, escribir, verificar existencia, leer líneas.
 * */

namespace archivoss
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter f1;
            f1 = File.CreateText("archivon.txt");
            f1.Write("Hola mundo :)");
            f1.Close();

            StreamReader f2;
            f2 = File.OpenText("archivon.txt");
            foreach (char c in f2.ReadToEnd())
            {
                Console.Write(c);
            }
            f2.Close();

            if (File.Exists("archivon.txt"))
            {
                Console.WriteLine("\nSi existe :) el archivo \"archivon.txt\"");
            }
            else
            {
                Console.WriteLine("\nNo existe :( el archivo \"archivon.txt\"");
            }
            Console.ReadKey();
        }
    }
}
