using System;

namespace clap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos números");
            Console.WriteLine("Número 1:");
            int num1;
            int num2;
            //Estructura de control de excepciones para el manejo de números
            do {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa un número");
                    Console.ReadKey();
                }
            } while (true);

            Console.WriteLine("Número 2:");
            //Estructura de control de excepciones para el manejo de números
            do
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa un número");
                    Console.ReadKey();
                }
            } while (true);

            Console.WriteLine();

            //Si es múltiplo de alguno de los dos imprime "clap" mediante el residuo
            for (int i = 1; i < 101; i++)
            {
                if (i % num1 == 0 || i % num2 == 0)
                {
                    Console.WriteLine("clap");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
