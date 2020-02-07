using System;
using System.Collections.Generic;
using System.Text;

namespace clasesabs
{
    abstract class Animal
    {
        string nombre;
        public Animal(string s)
        {
            nombre = s;
        }
        public string NombreComun { get { return nombre; } set { nombre = value; } }
        public abstract string Come { get; }

        public override string ToString()
        {
            return NombreComun + " " + Come;
        }
    }
}
