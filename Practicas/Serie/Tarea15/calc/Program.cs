
using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            //Variables para hacer las operacions básicas
            int opcion;
            double num1 = 0;
            double num2 = 0;
            do
            {
                //Menú repetitivo
                Console.WriteLine("Menú");
                //Caso 1 suma, caso 2 resta, caso 3 multiplica y caso 4 divide
                Console.WriteLine("Suma [1]\nResta [2]\nMultiplicación [3]\nDivisión [4]\nSalir [5]");
                //Try con dos catch, el primero si no es número y el segundo si es demasiado grande
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa un número");
                    opcion = -1;
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ingresa un número");
                    opcion = -1;
                    continue;
                }
                switch (opcion)
                {
                    case 1:
                        ObtenerNumeros(ref num1, ref num2);
                        //Una excepción que no se lanza, así que se verifica si los números son muy grandes para devolver un número verdadero
                        if (num1 + num2 > 999999999999999999 || num1 + num2 < -999999999999999999)
                        {
                            Console.WriteLine("El resultado es muy grande\n[Presiona una tecla para continuar]");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("{0} + {1} = {2}\n[Presiona una tecla para continuar]", num1, num2, num1 + num2);
                        Console.ReadKey();
                        break;
                    case 2:
                        ObtenerNumeros(ref num1, ref num2);
                        if (num1 - num2 > 999999999999999999 || num1 - num2 < -999999999999999999)
                        {
                            Console.WriteLine("El resultado es muy grande\n[Presiona una tecla para continuar]");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("{0} - {1} = {2}\n[Presiona una tecla para continuar]", num1, num2, num1 - num2);
                        Console.ReadKey();
                        break;
                    case 3:
                        ObtenerNumeros(ref num1, ref num2);
                        if (num1 * num2 > 999999999999999999 || num1 * num2 < -999999999999999999)
                        {
                            Console.WriteLine("El resultado es muy grande\n[Presiona una tecla para continuar]");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("{0} * {1} = {2}\n[Presiona una tecla para continuar]", num1, num2, num1 * num2);
                        Console.ReadKey();
                        break;
                    case 4:
                        ObtenerNumeros(ref num1, ref num2);
                        //Si intenta dividir entre cero sale un mensaje y rompe la estructura
                        if (num2 == 0)
                        {
                            Console.WriteLine("División entre 0 no se puede\n[Presiona una tecla para continuar]");
                            Console.ReadKey();
                            break;
                        }
                        if (num1 / num2 > 999999999999999999 || num1 / num2 < -999999999999999999)
                        {
                            Console.WriteLine("El resultado es muy grande\n[Presiona una tecla para continuar]");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("{0} / {1} = {2}\n[Presiona una tecla para continuar]", num1, num2, num1 / num2);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Adiós :)");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta\n[Presiona una tecla para continuar]");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opcion != 5);
        }

        public static void ObtenerNumeros(ref double num1, ref double num2)
        {
            do
            {
                //Do while para obtener valores verdaderos con un try-catch y un if para capturar una incongruencia de valores verdaderos
                try
                {
                    Console.WriteLine("Ingresa el primer número");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingresa el segundo número");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    //Si son mayores o menores, los bota
                    if(num1 > 999999999999999999 || num2 > 999999999999999999 || num1 < -999999999999999999 || num2 < -999999999999999999)
                    {
                        Console.WriteLine("No números tan grandes");
                        continue;
                    }

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa sólo números [Presiona una tecla para continuar]");
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}
