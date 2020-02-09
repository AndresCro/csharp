using System;

namespace fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un número");
            int num  = Convert.ToInt32(Console.ReadLine());
            fibonacci(num);
        }

        public static void fibonacci(int num)
        {
            int i, res, anterior = 0, actual = 1;
            if (num > 1) {
                for (i = 2; i < num + 1; i++)
                {
                    if (i == 2)
                    {
                        Console.WriteLine("0 - 0\n1 - 1");
                    }
                    res = anterior + actual;
                    anterior = actual;
                    actual = res;
                    Console.WriteLine("{0} - {1}", i, res);
                }
            }
            else if ( num == 0)
            {
                Console.WriteLine("0 - 0");
            }
            else if ( num == 1)
            {
                Console.WriteLine("0 - 0\n1 - 1");
            }
        }
    }
}