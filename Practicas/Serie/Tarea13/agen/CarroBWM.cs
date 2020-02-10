using System;
using System.Collections.Generic;
using System.Text;

namespace agencia
{
    class CarroBWM : Carro
    {
        string modelo;

        public CarroBWM(double peso, double altura) : base(peso, altura)
        {
            this.modelo = "BWM";
        }
        //Características del auto con turbo
        public override string ToString()
        {
            return "Tengo turbo\nEl peso es: " + peso + "\nLa altura es: " + altura + "\nEl modelo es: " + modelo + ".";
        }
    }
}
