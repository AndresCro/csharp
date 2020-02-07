using System;
using System.Collections.Generic;
using System.Text;

namespace Calificaciones
{
    public static class Calculadora
    {
        public static int Calculo(int proyecto, int tareas, int participacion)
        {
            if (participacion < 5)
                return (proyecto * 6) + (tareas * 2 * 4);
            return (proyecto * 6) + (tareas * 2 * 4) + (8);
        }
    }
}
