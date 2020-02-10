using System;
using System.Collections.Generic;
using System.Text;

namespace agencia
{
    class CarroVW : Carro
    {
        string modelo;

        public CarroVW(double peso, double altura) : base(peso, altura)
        {
            this.modelo = "VW";
        }
        //Características del auto con modelo
        public override string ToString()
        {
            return "El peso es: " + peso + "\nLa altura es: " + altura + "\nEl modelo es: " + modelo + ".";
        }
    }
}
