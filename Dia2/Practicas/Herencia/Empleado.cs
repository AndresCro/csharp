using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Empleado: Persona
    {
        public string Puesto { get; set; }
        public string Sueldo { get; set; }

        public Empleado(string nombre, int e)
    }
}
