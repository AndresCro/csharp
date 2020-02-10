using System;
using System.Collections.Generic;
using System.Text;

namespace Personas
{
    class Persona
    {
        //Variables predeterminadas
        string nombre;
        int edad;
        double estatura;
        double peso;

        //Constructor necesario de inicialización
        public Persona(string nombre, int edad, double estatura, double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.estatura = estatura;
            this.peso = peso;
        }

        //Una persona puede dibujar, así que un cuadrado se me ocurrió, hace uno 5 x 10 pero en imagen se ve como un cuadrado
        public void DibujarCuadro()
        {
            Console.WriteLine("Dibujo un cuadrado");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Si extremos de renglon dibuja --------
                    if (i == 0 || i == 4)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        //Si son extremos de columna dibuja |
                        if (j == 0 || j == 9)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine();
            }
        }

        //Calcula el IMC de una persona mediante el peso y la estatura en metros
        public void Imc()
        {
            Console.WriteLine("El IMC de la persona es: " + (peso) / (Math.Pow(estatura, 2)));
        }

        //Muestra la información de una persona
        public void Informacion()
        {
            Console.WriteLine("Me llamo {0}, tengo {1} años, mido {2:0.00}m y peso {3:0.00}", nombre, edad, estatura, peso);
        }
    }
}