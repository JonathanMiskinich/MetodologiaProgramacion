using Clases.Alumnos;
using Interfaz.IAlumnos;

namespace Interfaces.PStrategy_Comparacion
{
    public class ComparacionCalificacion : Comparacion
    {
        public bool Iguales(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getCalificacion() == alumY.getCalificacion();
        }

        public bool MayorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getCalificacion() > alumY.getCalificacion();
        }

        public bool MenorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getCalificacion() < alumY.getCalificacion();
        }
    }
}