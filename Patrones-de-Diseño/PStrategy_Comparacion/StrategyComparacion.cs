using System;
using Interfaz.IAlumnos;

namespace Alumnos.Comparaciones
{
    public interface Comparacion
    {
        bool Iguales(IAlumno alumX, IAlumno alumY);
        bool MayorQue(IAlumno alumX, IAlumno alumY);
        bool MenorQue(IAlumno alumX, IAlumno alumY);
    }
}