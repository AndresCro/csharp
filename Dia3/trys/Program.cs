using System;

namespace trys
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Convert FormatException
                Console.Write("Ingresa el numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                //Division DivideByZeroException
                int resultado = numerador / denominador;

                Console.WriteLine("\nResultado: {} / {}  {}", numerador, denominador, resultado);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("\n" + de.Message);
            }
        }
    }
}
