using System;

namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apPaterno;
            string apMaterno;
            string cuenta;
            int proyecto;
            int participaciones;
            int tareas;
            int calificacion;

            Console.WriteLine("Cuántos alumnos serán calificados");
            int numeros = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[numeros];

            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine("Datos del alumno");

                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Apellido paterno: ");
                apPaterno = Console.ReadLine();
                Console.Write("Apellido materno: ");
                apMaterno = Console.ReadLine();
                Console.Write("Cuenta: ");
                cuenta = Console.ReadLine();
                Console.Write("Proyecto: ");
                proyecto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Participaciones: ");
                participaciones = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tareas: ");
                tareas = Convert.ToInt32(Console.ReadLine());

                calificacion = Calculadora.Calculo(proyecto, tareas, participaciones);

                if (calificacion > 100)
                {
                    calificacion = 100;
                }else if(calificacion < 50)
                {
                    calificacion = 50;
                }

                alumnos[i] = new Alumno(nombre,apPaterno,apMaterno,cuenta,participaciones,proyecto,tareas,  calificacion);
            }

            foreach (Alumno alma in alumnos)
            {
                Console.WriteLine(alma.ToString());
            }
            Console.ReadKey();
        }
    }
}
