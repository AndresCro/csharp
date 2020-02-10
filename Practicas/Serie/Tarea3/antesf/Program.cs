using System;

namespace antesf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena");

            //Lee la cadena y la transforma a lower
            string cad = Console.ReadLine();
            string cad2 = cad.ToLower();
            //Checa caracter por caracter si tiene una vocal
            for(int c = 0; c < cad.Length; c++)
            {
                //Si lo tiene imprime una f antes de la cadena original (la que no está en lower)
                if (cad2[c].Equals('a') || cad2[c].Equals('e') || cad2[c].Equals('i') || cad2[c].Equals('o') || cad2[c].Equals('u'))
                {
                    Console.Write("f" + cad[c]);
                }
                //De lo contrario imprime el caracter
                else
                {
                    Console.Write(cad[c]);
                }
            }
        }
    }
}
