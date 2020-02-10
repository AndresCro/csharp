using System;
using System.Collections.Generic;
using System.Text;

namespace todo
{
    class Instituto
    {
        //Variables para heredar sin encapsulación
        protected string nombre;
        protected string ubicacion;

        //Método constructor
        public Instituto(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        //Abstracción -> Información que sirve
        public virtual void Datos()
        {
            Console.WriteLine("La institución {0} se encuentra en {1}", nombre, ubicacion);
        }
    }
}
