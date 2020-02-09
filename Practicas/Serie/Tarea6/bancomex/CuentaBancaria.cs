using System;
using System.Collections.Generic;
using System.Text;

namespace bancomex
{
    class CuentaBancaria
    {
        double saldo;
        string nombre;

        public CuentaBancaria(string nombre, double saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre {0} tiene de saldo: {1}", nombre, saldo);
        }

        public void Deposito(double dinero)
        {
            saldo += dinero;
            MostrarInformacion();
        }

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
