using System;
using System.Collections.Generic;
using System.Text;


/*Función
 * En una orginización se tienen muchas personas con diferentes roles
 * Cada rol una serie de permisos, así que es necesario indicar que una persona es de tipo persona con rol diferente, empleado, cliente, gerente, persona, lo que se necesite*/

namespace poli
{
    class Persona
    {
        //Se debe indicar la visibilidad para que sea posible heredar
        protected string nombre;
        protected int edad;

        //Método para crear personas
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        
        //En mi caso voy a sobreescribir el método Datos, por lo tanto es necesrio usar virtual
        public virtual void Datos()
        {
            Console.WriteLine("La persona {0} tiene {1} años",nombre, edad);
        }
    }

    class Empleado : Persona
    {
        //La nueva variable que la hace diferente
        int sueldo;

        //Llamo a base para obtener sus atributos
        public Empleado(string nombre, int edad, int sueldo) : base(nombre, edad)
        {
            this.sueldo = sueldo;
        }

        //Sobreescribo Datos
        public override void Datos()
        {
            Console.WriteLine("La persona {0} tiene {1} años tiene un sueldo de {2}", nombre, edad, sueldo);
        }
    }
}
