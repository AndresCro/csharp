using System;

namespace todo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 Pilares");

            //Polimorfismo -> Misma clase diferente instancia de objeto
            Instituto u1 = new Instituto("UNAM","Rectoria");
            Instituto u2 = new Beca("DGTIC", "enfrente de la FCA", 26, 20);

            //Demostración de polimorfismo
            u1.Datos();
            u2.Datos();
        }
    }
}
