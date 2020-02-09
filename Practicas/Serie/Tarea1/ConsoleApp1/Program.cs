using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            for(int i = 1; i < num + 1; i++)
            {
                res += i;
            }
            Console.WriteLine("El resultado es: {0}",res);
        }
    }
}
