using System;

/*Math
 * Uso para expresiones aritméticas, manejo de números y expresiones trigonométricas.
 * Se encuentra en System.
 * Es una clase estática.
 * Tiene 2 constantes -> E y PI
 * Métodos
 *      Abs Regresa el valor absoluto de un decimal, doble, int16, int 32, int 64, int 8.
 *      Acos Regresa el ángulo del coseno.
 *      Asin Regresa el ángulo del seno.
 *      Atan Regresa el ángulo de la tangente.
 *      Atan2 Regresa el ángulo de la tangente con dos numeros.
 *      BigMul Hace el producto total de dos números de 32 bits.
 *      Ceiling  Regresa el valor inferior -> 35.2 = 35.
 *      Cos Regresa el coseno de un ángulo.
 *      Cosh Regresa el coseno hiperbolico de un ángulo.
 *      DivRem Regresa el restante del cociente de dos números en un parámetro. 
 *      Exp Regresa E elevado a una potencia.
 *      Floor Regresa el valor superior -> 35.2 = 36.
 *      IEEERemainder Regresa el restante del resultado de la división de dos números.
 *      Log Regresa el logaritmo natural de un número.
 *      Max Regresa el número más grande de dos números.
 *      Min Regresa el número más pequeño de dos números.
 *      Pow Regresa el valor de un número elevado a una potencia.
 *      Round Regresa el valor inferior o superior dependiendo de sus decimales -> 32.5 = 32 , 32.6 = 33.
 *      Sign Regresa un número que indica el signo.
 *      Sin Regresa el seno de un ángulo.
 *      Sinh Regresa el seno hiperbólico de un ángulo.
 *      Sqrt Regresa la raiz cuadrada de un número.
 *      Tan Regresa la tangente de un ángulo.
 *      Tanh Regresa la tangente hiperbólica de un ángulo.
 *      Truncate Regresa la parte entera de un número.
 */

namespace usomath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figuras Tarea - 9");

            //Creación del cpirculo
            Circulo c = new Circulo(2.5);

            //Creación del triangulo
            Triangulo t = new Triangulo(1, 2, 80.1, 60.3, 34.4);

            //Uso de los métodos del circulo y triangulo con Math
            Console.WriteLine("Area del círculo: "+ c.AreaCirculo());
            Console.WriteLine("Seno del ángulo de la hipotenusa y cateto opuesto: {0} = {1} " ,t.AnguloHO, t.SenoHO());
        }
    }
}
