using System;
using System.Collections.Generic;
using System.Text;

namespace inter
{
    //Cada clase tienes sus propias variables que ayudan a implementar la interfaz
    class Triangulo : IFigura
    {
        //Necesita dos variables
        double bases;
        double altura;

        //Constructor para inicilizar las variables y así sacar el área
        public Triangulo(double bases, double altura)
        {
            this.bases = bases;
            this.altura = altura;
        }

        //Modelo
        public double Area()
        {
            return (bases*altura) / 2;
        }
    }
    class Rectangulo : IFigura
    {
        //Necesita dos variables
        double bases;
        double altura;

        //Constructor para inicilizar las variables y así sacar el área
        public Rectangulo(double bases, double altura)
        {
            this.bases = bases;
            this.altura = altura;
        }

        //Modelo
        public double Area()
        {
            return bases * altura;
        }
    }

    class Circulo : IFigura
    {
        //Necesita una variable
        double radio;

        //Constructor para inicilizar la variable y así sacar el área
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        //Modelo
        public double Area() { 
        
            return Math.PI * radio * radio;
        }

    }
}
