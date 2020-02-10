using System;

namespace autos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autos");

            //Creación de los tres carros con su constructor diferente
            Auto a1 = new Auto();
            Auto a2 = new Auto("rojo");
            Auto a3 = new Auto(4, "Negro", 4, 250.5);

            //Uso de getters y setters del A1
            //Uso del método 1 y 2
            Console.WriteLine("A1");
            a1.Asientos = 5;
            a1.Color = "Rojo";
            a1.Llantas = 4;
            a1.MostrarInformacion();
            a1.Capacidad();

            //Uso del get Velocidad
            Console.WriteLine("A2");
            a2.Velocidad = 100.00;
            Console.WriteLine("El auto A2 tiene un velocidad de {0} Km/h", a2.Velocidad);

            //Uso de del tercer método
            Console.WriteLine("A3");
            a3.Calculo();
            
        }
    }
}
