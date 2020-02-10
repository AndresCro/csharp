using System;
using System.Collections.Generic;
using System.Text;

namespace usomath
{
    class Circulo
    {
        //Variable para obtener los resultados
        double radio;

        //Constructor de inicialización del círculo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        //Área del círculo con Pow
        public double AreaCirculo()
        {
            return Math.PI * (Math.Pow(radio, 2));
        }

        //Valor absoluto del radio.
        public double Absoluto()
        {
            return Math.Abs(radio);
        }

        //Valor del area al número más cercano.
        public double AreaEntera()
        {
            return Math.Round(AreaCirculo());
        }
    }
}
