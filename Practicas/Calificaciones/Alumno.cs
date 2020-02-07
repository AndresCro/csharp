using System;
using System.Collections.Generic;
using System.Text;

namespace Calificaciones
{
    class Alumno
    {
        string nombre;
        string apPat;
        string apMat;
        string cuenta;

        int calificacion;
        int participacion;
        int proyecto;
        int tareas;

        public Alumno(string nombre, string apPat, string apMat, string cuenta, int participacion, int proyecto, int tareas, int calificacion)
        {
            this.nombre = nombre;
            this.apPat = apPat;
            this.apMat = apMat;
            this.cuenta = cuenta;
            this.proyecto = proyecto;
            this.participacion = participacion;
            this.tareas = tareas;
            this.calificacion = calificacion;
        }

        public int Participacion
        {
            get { return participacion; }
            set { participacion = value; }
        }
        public int Proyecto
        {
            get { return proyecto; }
            set { proyecto = value; }
        }
        public int Tareas
        {
            get { return tareas; }
            set { tareas = value; }
        }

        public override string ToString()
        {
            return "El alumno: " +nombre+ " tiene de calificación final : " + calificacion;
        }
    }
}
