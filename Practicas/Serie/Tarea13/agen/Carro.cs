using System;
using System.Collections.Generic;
using System.Text;

namespace agencia
{
    class Carro
    {
        //Variables base
        protected double peso;
        protected double altura;
        protected bool encendido;

        //Método constructor con encendido en false
        public Carro(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
            this.encendido = false;
        }
        //Método para encender con mensaje
        public void Encender()
        {
            Console.WriteLine("El carro está encendido");
            encendido = true;
        }
        //Método para apagar con mensaje
        public void Apagar()
        {
            Console.WriteLine("El carro está apagado");
            encendido = false;
        }
        //Getters y setters
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        //Método para ver si está encendido
        public void Estado()
        {
            Console.WriteLine((encendido == true) ? "Está encendido" : "Está apagado");
        }
        //Características del auto
        public override string ToString()
        {
            return "El peso es: " + peso + "\nLa altura es:" + altura + ".";
        }
    }
}
