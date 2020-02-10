using System;
using System.Collections.Generic;
using System.Text;

namespace todo
{
    //Herencia -> La beca surge a partir de  un instituto
    class Beca : Instituto
    {
        int becarios;
        int profesoresBecarios;

        //Método constructor
        public Beca(string nombre, string ubicacion, int becarios, int profesoresBecarios) : base(nombre, ubicacion)
        {
            this.becarios = becarios;
            this.profesoresBecarios = profesoresBecarios;
        }

        //Herencia, polimorfismo y abstracción -> Override de un método ya creado con datos más relevantes
        public override void Datos()
        {
            Console.WriteLine("La institución {0} se encuentra en {1} y tiene {2} alumnos con {3} profesores de beca", nombre, ubicacion, becarios, profesoresBecarios);
        }

        //Encapsulación de los atributos
        public int Becarios
        {
            get { return becarios; }
            set { becarios = value; }
        }
        public int Profesores
        {
            get { return profesoresBecarios; }
            set { profesoresBecarios = value; }
        }
    }        
}
