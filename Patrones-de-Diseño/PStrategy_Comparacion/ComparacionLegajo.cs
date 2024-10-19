using Clases.Alumnos;
using IAlumnos;

namespace Alumnos.Comparaciones
{
    public class ComparacionLegajo : Comparacion
    {
        public bool Iguales(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getLegajo() == alumY.getLegajo();
        }

        public bool MayorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getLegajo() > alumY.getLegajo();
        }

        public bool MenorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getLegajo() < alumY.getLegajo();
        }
    }
}