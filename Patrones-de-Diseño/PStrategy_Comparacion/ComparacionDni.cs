using Clases.Alumnos;
using IAlumnos;

namespace Alumnos.Comparaciones
{
    public class ComparacionDni : Comparacion
    {
        public bool Iguales(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getDni() == alumY.getDni();
        }

        public bool MayorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getDni() > alumY.getDni();
        }

        public bool MenorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getDni() < alumY.getDni();
        }
    }
}