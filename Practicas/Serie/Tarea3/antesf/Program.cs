using System;

namespace antesf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena");
            string cad = Console.ReadLine();
            string cad2 = cad.ToLower();
            for(int c = 0; c < cad.Length; c++)
            {
                if (cad2[c].Equals('a') || cad2[c].Equals('e') || cad2[c].Equals('i') || cad2[c].Equals('o') || cad2[c].Equals('u'))
                {
                    Console.Write("f" + cad[c]);
                }
                else
                {
                    Console.Write(cad[c]);
                }
            }
        }
    }
}
