using System;

namespace inter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso de interfaces");
            Console.WriteLine("Cálculo de áreas con diferentes modelos");

            //Instancia de las clases con la interfaz, todos dependen de la interfaz

            IFigura tr = new Triangulo(6.5, 8.9);
            IFigura rc = new Rectangulo(10, 5);
            IFigura cr = new Circulo(8.9);

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
