using System;

namespace Arreglo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = {1,2,3,6,5,4,3,8,9,10};
            int[] temp = new int[arreglo.Length];

            Array.Copy(arreglo, temp, arreglo.Length);
            Console.WriteLine("Arreglo original: ");
            MostrarArreglo(arreglo);
            Array.Reverse(temp);
            Console.WriteLine("Arreglo invertido: ");
            MostrarArreglo(temp);
            Console.WriteLine("Arreglo ordenado: ");
            Array.Sort(arreglo);
            MostrarArreglo(arreglo);

            Console.WriteLine("indice del número 8: " + Array.IndexOf(temp, 8));
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.WriteLine("{0}", num);
            }
        }
    }
}