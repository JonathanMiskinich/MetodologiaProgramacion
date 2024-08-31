using System;
using Clases.Alumno;

namespace Interfaces.PStrategy_Comparacion
{
    public interface Comparacion
    {
        bool ComparacionIguales(Alumno alumX, Alumno alumY);
    }
}