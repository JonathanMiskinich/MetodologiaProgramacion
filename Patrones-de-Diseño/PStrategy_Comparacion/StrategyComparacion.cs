using System;
using Interfaz.IAlumnos;

namespace Interfaces.PStrategy_Comparacion
{
    public interface Comparacion
    {
        bool Iguales(IAlumno alumX, IAlumno alumY);
        bool MayorQue(IAlumno alumX, IAlumno alumY);
        bool MenorQue(IAlumno alumX, IAlumno alumY);
    }
}