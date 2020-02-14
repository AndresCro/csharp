using System;
using System.Linq;
using System.Collections.Generic;

namespace parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] nums = { 1, 4, 2, 5, 9, 6 };
            Console.WriteLine("Arreglo original");
            Imprime(nums);

            //Query para obtener los números mayores a 4.

            var filtro =
                from n in nums
                where n > 4
                select n;

            Console.WriteLine("Arreglo filtrado");
            Imprime(filtro);

            //Ordenar el arreglo

            var ordenar =
                from n in nums
                orderby n
                select n;


            Console.WriteLine("Arreglo ordenado UP");
            Imprime(ordenar);

            var ordenar2 =
                from n in nums
                orderby n descending
                select n;

            Console.WriteLine("Arreglo ordenado DOWN");
            Imprime(ordenar2);

            var todo =
                from n in filtro
                orderby n
                select n;

            Console.WriteLine("Arreglo ordenado UP > 4");
            Imprime(todo);*/

            string[] paises = { "Mexico", "Rusia", "Ucrania", "Uganda", "Tunez" };

            //Los que tienen 'a' y ordenados por longitud

            IEnumerable<string> query =
                from p in paises
                where p.Contains('a') && p.Contains('u')
                orderby p.Length
                select p;

            Imprime(query);
            //Long mayor a 5

            Console.WriteLine("Paises mayor a 5");

            IEnumerable<string> query2 =
                from p in paises
                where p.Length > 5
                select p;

            Imprime(query2);

            //Iniciales de los paies

            IEnumerable<char> query3 =
                from p in paises
                select p[0];

            Imprime(query3);

        }

        static void Imprime<T>(IEnumerable<T> nums)
        {
            foreach (T a in nums)
            {
                Console.WriteLine(a);
            }
        }

    }
}
