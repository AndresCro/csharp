using System;
using System.Collections.Generic;
using System.Text;

namespace numeros
{
    class NumeroComplejo
    {
        int parteReal;
        int parteImaginaria;
        
        public NumeroComplejo(int parteReal, int parteImaginaria)
        {
            this.parteImaginaria = parteImaginaria;
            this.parteReal = parteReal;
        }
        public static NumeroComplejo operator +(NumeroComplejo a, NumeroComplejo b)
        {
            NumeroComplejo c = new NumeroComplejo(a.parteReal + b.parteReal, a.parteImaginaria + b.parteImaginaria);
            return c;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("{0} + {1}i", parteReal, parteImaginaria);
        }
    }
}
