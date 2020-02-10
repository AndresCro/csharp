using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int num;
            //Try para el manejo de excepciones mediante un do while, hasta que ingrese un número
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa un número");
                    Console.ReadKey();
                }
            } while (true);

            //Se puede hacer con una función recursiva, pero si se le llama muchas veces entonces es muy lenta
            int res = 0;
            //Suma de uno en uno hasta el número indicado
            for(int i = 1; i < num + 1; i++)
            {
                res += i;
            }
            Console.WriteLine("El resultado es: {0}",res);
            Console.ReadKey();
        }
    }
}
