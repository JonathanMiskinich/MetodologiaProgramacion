using System;
using Clases.Alumnos;

namespace Interfaces.PStrategy_Comparacion
{
    public interface Comparacion
    {
        bool ComparacionIguales(Alumno alumX, Alumno alumY);
    }
}