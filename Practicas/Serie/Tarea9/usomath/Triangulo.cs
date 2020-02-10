using System;
using System.Collections.Generic;
using System.Text;



namespace usomath
{
    class Triangulo
    {
        //Variables para obtener el seno, coseno, tangente y área*

        double lado;
        double altura;

        /*angulo HA -> Hipotenusa y cateto adyacente, HO -> Hipotenusa y cateto opuesto, AO -> Cateto adyacente y opuesto.
        * Cada uno representa un ángulo*/
        double anguloHA;
        double anguloHO;
        double anguloAO;

        //Constructor de inicialización de las variables
        public Triangulo(double lado, double altura, double anguloHA, double anguloHO, double anguloAO)
        {
            this.altura = altura;
            this.lado = lado;
            this.anguloHA = anguloHA;
            this.anguloHO = anguloHO;
            this.anguloAO = anguloAO;
        }

        /*Obtiene el coseno, seno y tangente de cada ángulo*/
        public double CosenoHA()
        {
            return Math.Cos(anguloHA);
        }

        public double SenoHA()
        {
            return Math.Sin(anguloHA);
        }

        public double TangenteHA()
        {
            return Math.Tan(anguloHA);
        }
        public double CosenoHO()
        {
            return Math.Cos(anguloHO);
        }

        public double SenoHO()
        {
            return Math.Sin(anguloHO);
        }

        public double TangenteHO()
        {
            return Math.Tan(anguloHO);
        }
        public double CosenoAO()
        {
            return Math.Cos(anguloAO);
        }

        public double SenoAO()
        {
            return Math.Sin(anguloAO);
        }

        public double TangenteAO()
        {
            return Math.Tan(anguloAO);
        }

        //Termina las funciones Math

        //Y pues no debe faltar el área
        public double Area()
        {
            return (lado * altura) / 2;
        }

        //Getters y setters
        public double AnguloHA
        {
            get { return anguloHA;}
        }

        public double AnguloHO
        {
            get { return anguloHO; }
        }

        public double AnguloAO
        {
            get { return anguloAO; }
        }
    }
}
