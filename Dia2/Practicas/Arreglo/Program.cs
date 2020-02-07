using System;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el tamaño del arrehlo: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tam];
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Indice {0}: ", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Los datos que ingresaste son: ");
            MostrarArreglo(numeros);
            Console.ReadKey();
        }
        void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.WriteLine("{0}", num);
            }
        }
    }  
}
