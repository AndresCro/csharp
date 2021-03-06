﻿using System;

namespace bancomex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bancomex");

            //Creación de dos cuentas bancarias
            CuentaBancaria cb1 = new CuentaBancaria("Carlos", 50000.00);
            CuentaBancaria cb2 = new CuentaBancaria("Andrés", 1000000.00);

            /* Muestra los datos indicados:
             * Nombre
             * Saldo y nombre
             * Saldo y nombre con deposito 
             * Saldo y nombre con retiro*/

            Console.WriteLine("Cuenta Carlos");
            Console.WriteLine("Mostrar Información");
            cb1.MostrarInformacion();
            Console.WriteLine("Depósito de 30000");
            cb1.Deposito(30000.00);
            Console.WriteLine("Retiro de 40000");
            cb1.Retiro(40000.00);

            /* Muestra los datos indicados:
             * Nombre
             * Saldo y nombre
             * Saldo y nombre con deposito 
             * Saldo y nombre con retiro mayor al saldo*/

            Console.WriteLine("Cuenta Andrés");
            Console.WriteLine("Mostrar Información");
            cb2.MostrarInformacion();
            Console.WriteLine("Depósito de 300");
            cb2.Deposito(300.00);
            Console.WriteLine("Retiro de 40000000");
            cb2.Retiro(400000000.00);
        }
    }
}

