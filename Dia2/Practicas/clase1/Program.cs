using System;

namespace clase1
{
    class Program
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro del name");
        }
    }
}

class uno
{
    public void metodo()
    {
        Console.WriteLine("Afuera");
    }
}

namespace Namespace
{
    class Program
    {
        static void Main()
        {
            clase1.Program Program = new clase1.Program();
            uno obj2 = new uno();
        }
    }
}