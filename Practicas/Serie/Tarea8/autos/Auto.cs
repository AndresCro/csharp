using System;
using System.Collections.Generic;
using System.Text;

namespace autos
{
    class Auto
    {
        //Variables para hacer uso de los métodos
        private int llantas;
        private string color;
        private int asientos;
        private double velocidad;

        //Override del constructor 3 veces
        public Auto()
        {

        }

        public Auto(int llantas, string color, int asientos, double velocidad)
        {
            this.llantas = llantas;
            this.color = color;
            this.asientos = asientos;
            this.velocidad = velocidad;
        }

        public Auto(string color)
        {
            this.color = color;
        }

        //Getters and setters
        public int Llantas
        {
            get{ return llantas; }
            set{ llantas = value;}
        }

        public int Asientos
        {
            get { return asientos; }
            set { asientos = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        //Método 1 -> Mostrar las características del auto
        public void MostrarInformacion()
        {
            Console.WriteLine("El auto tiene {0} llantas, {1} asientos y es de color {2}", llantas, asientos, color);
        }

        //Método 2 -> Mostrar la capicidad del auto
        public void Capacidad()
        {
            Console.WriteLine("El auto puede soportar hasta {0} personas", asientos + 1);
        }

        //Método 3 -> Mostrar la distancia que recorre en 10 min
        public void Calculo()
        {
            Console.WriteLine("El auto recorre hasta {0:0.00}Km en 10 min",velocidad * 0.1666);
        }
    }
}
