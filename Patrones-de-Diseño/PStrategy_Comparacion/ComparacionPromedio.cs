using IAlumnos;

namespace Alumnos.Comparaciones
{
    public class ComparacionPromedio : Comparacion
    {
        public bool Iguales(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getPromedio() == alumY.getPromedio();
        }

        public bool MayorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getPromedio() > alumY.getPromedio();
        }

        public bool MenorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getPromedio() < alumY.getPromedio();
        }
    }
}