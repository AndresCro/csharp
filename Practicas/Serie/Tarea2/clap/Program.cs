using System;

namespace clap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos números");
            Console.WriteLine("Número 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

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
