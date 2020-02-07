using System;

public class Persona
{
    private int edad;
    private string nombre;
    public Persona(String nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        Persona p = obj as Persona;
        return (nombre == p.nombre) && (edad == p.edad);
    }

}
