using System;

namespace inter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso de interfaces");
            Console.WriteLine("Cálculo de áreas con diferentes modelos");

            //Instancia de las clases

            Triangulo tr = new Triangulo(6.5, 8.9);
            Rectangulo rc = new Rectangulo(10, 5);
            Circulo cr = new Circulo(8.9);

            //Demostración del uso de la interfaz
            Console.WriteLine("Triangulo");
            Console.WriteLine("El área es: "+tr.Area());
            Console.WriteLine("Rectangulo");
            Console.WriteLine("El área es: " + rc.Area());
            Console.WriteLine("Círculo");
            Console.WriteLine("El área es: " + cr.Area());
        }
    }
}
