using System;
using System.Collections.Generic;
using System.Text;

namespace clasesabs
{
    class Lobo : Carnivoro
    {
        public Lobo(string nombre) : base(nombre) { }
        public void MuestraColmillos()
        {
            Console.WriteLine("Mírame");
        }
        public override void Cazar()
        {
            Console.WriteLine("El " + NombreComun + "mata");
        }
    }

    class Pinguinno : Carnivoro
    {
        public Pinguinno(string nombre) : base(nombre) { }

        public void Deslizar()
        {
            Console.WriteLine("Desliz");
        }
        public void Cazar()
        {
            Console.WriteLine("Mi pico");
        }
    }
}
