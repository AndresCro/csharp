using System;
using System.Collections.Generic;
using System.Text;

namespace numeros
{
    class NumeroComplejo
    {
        //Variables solicitadas
        int parteReal;
        int parteImaginaria;
        
        //Creación del número complejo
        public NumeroComplejo(int parteReal, int parteImaginaria)
        {
            this.parteImaginaria = parteImaginaria;
            this.parteReal = parteReal;
        }

        //Modificador de + para hacer la suma de dos números complejos de forma fácil
        public static NumeroComplejo operator +(NumeroComplejo a, NumeroComplejo b)
        {
            NumeroComplejo c = new NumeroComplejo(a.parteReal + b.parteReal, a.parteImaginaria + b.parteImaginaria);
            return c;
        }

        //Imprime el número complejo
        public void MostrarInformacion()
        {
            Console.WriteLine("{0} + {1}i", parteReal, parteImaginaria);
        }
    }
}
