using System;

namespace gene
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] enteros = { 1, 2, 3, 45, 6, 7, 4 };
            double[] doble = { 1.12, 123.3213, 31.32134, 44.123 };
            char[] carac = { '1', 'd', '2', 'k', 'd', 'g' };
            Console.WriteLine("enteros: ");
            MostrarArreglo(enteros);
            Console.WriteLine("\ndoble: ");
            MostrarArreglo(doble);
            Console.WriteLine("\ncarac: ");
            MostrarArreglo(carac);
        }

        public static void MostrarArreglo <T> (T[] arreglo)
        {
            foreach(T i in arreglo)
            {
                Console.Write(i);
            }
        }
    }
}
