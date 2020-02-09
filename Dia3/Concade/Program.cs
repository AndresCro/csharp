using System;

namespace Concade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola"  + "mundo");
            Console.WriteLine(String.Concat("Hola", "Mundo"));

            string cadena = "Esta es una cadena";

            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño: " + cadena.Length);
            Console.WriteLine("Mayus: " + cadena.ToUpper());
            Console.WriteLine("Minis: " + cadena.ToLower());
            Console.WriteLine("Replace: " + cadena.Replace(" ", ""));
            Console.WriteLine("Caracter 0: " + cadena[0]);
            Console.WriteLine("Sub: " + cadena.Substring(1, 8));
            Console.WriteLine("Contiene \"es\"?: " + cadena.Contains("es"));

            int naranjas = 8;
            int platanos = 2;
            int fresas = 3;
            { -}

            string formaton = String.Format("Naranjas = {0}\nPlatanos = {1}\nFresas = {2}", naranjas,platanos,fresas);
            Console.WriteLine(formaton);

            Console.WriteLine("PI: {0:0.00}", Math.PI);

            Console.WriteLine("Numero: {0:N}", 123123);
            Console.WriteLine("Cientifica {0:E}", 1231.123123131);
            Console.WriteLine("Moneda {0:C}", 23123);
            Console.WriteLine("Hexa {0:X}", 7);

        }
    }
}
