using System;

namespace Expec
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa un valor de raiz: ");
                double dato = Convert.ToDouble(Console.ReadLine());
                double res = RaizCuadrada(dato);
                Console.WriteLine("Raiz cuadrada de {} es {}", dato, res);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
            }
            catch (NegativonException ne)
            {
                Console.WriteLine("\n" + ne.Message);
            }
        }

        public static double RaizCuadrada(double dato)
        {
            if (dato < 0)
            {
                throw new NegativonException();
            }
            return Math.Sqrt(dato);
        }

    }
}
