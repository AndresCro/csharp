  using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1224
{
    class Cliente
    {
        string nombre;
        int edad;
        int cuenta;
        double dinero;
        Random rm = new Random();
        public static int contador = 0;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            dinero = 5000;
            cuenta = rm.Next(0, 100);
            edad = 18;
            contador++;
        }

        public static string msj()
        {
            return "Bienvenidos a C#";
        }

        public override string ToString()
        {
            return String.Format("Nombre: {}, Edad: {}", nombre, edad);
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 0)
                    edad = 18;
                else
                    edad = value;
            }
        }
        public int Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        public void Retirar(double cantidad)
        {
            if (cantidad > dinero)
                Console.WriteLine(":(");
            else
                dinero -= cantidad;
        }

        public void Depositar(double cantidad)
        {
            dinero += cantidad;
        }
    }
}
