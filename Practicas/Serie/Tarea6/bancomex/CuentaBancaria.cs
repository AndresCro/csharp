using System;
using System.Collections.Generic;
using System.Text;

namespace bancomex
{
    class CuentaBancaria
    {
        //Variables solicitadas
        double saldo;
        string nombre;

        //Pide los datos para la creación de una cuenta bancaria
        public CuentaBancaria(string nombre, double saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;
        }
        //Muestra los datos
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre {0} tiene de saldo: {1}", nombre, saldo);
        }

        //Solicita el deposito
        public void Deposito(double dinero)
        {
            saldo += dinero;
            MostrarInformacion();
        }

        //Si ee mayor al saldo actual, lo niega
        public void Retiro(double dinero)
        {
            if (saldo < dinero)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                saldo -= dinero;
                MostrarInformacion();
            }
        }
    }
}
