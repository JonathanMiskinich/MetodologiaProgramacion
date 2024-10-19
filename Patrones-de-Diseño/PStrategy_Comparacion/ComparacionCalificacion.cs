using Clases.Alumnos;
using IAlumnos;

namespace Alumnos.Comparaciones
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