using System;

namespace fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un número");
            int num;
            //Estructura de control de excepciones para el manejo de números
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

            fibonacci(num);
        }

        //Este procedimiento puede ser recursivo, pero para mayor eficiencia se usa un for, porque muchas llamadas usan más recursos que un for
        public static void fibonacci(int num)
        {
            //Variables para hacer la suma del anterior y el actual, ej: {1} + [2] = [3] -> {2} + [3] = [5]
            //Se conservan los dos siguientes y se actualiza el anterior al actual, el actual a resultado y el resultado a la suma de estos dos
            int i, res, anterior = 0, actual = 1;
            //Si ingreso un número mayor a 1 hace la impresón de la serie de fibonacci
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
            //De lo contrario solo imprime el valor 0
            else if ( num == 0)
            {
                Console.WriteLine("0 - 0");
            }
            //De lo contrario solo imprime el valor 0 y 1
            else if ( num == 1)
            {
                Console.WriteLine("0 - 0\n1 - 1");
            }
        }
    }
}