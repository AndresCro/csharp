using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        private static readonly string[] colores = { "rojo", "azul", "verde" };
        private static readonly string[] removercolor = { "rojo", "morado" };
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            foreach(var color in colores)
            {
                lista.Add(color);
            }

            List<string> removeLista = new List<string>(removercolor);

            MostrarLista(lista);

        }

        private static void MostrarLista(List<string> lista)
        {
            foreach(var elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }

    }
}
