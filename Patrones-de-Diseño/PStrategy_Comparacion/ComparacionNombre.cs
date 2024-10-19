using Clases.Alumnos;
using Interfaz.IAlumnos;

namespace Alumnos.Comparaciones
{
    public class ComparacionNombre : Comparacion
    {
        public bool Iguales(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getNombre == alumY.getNombre;
        }

        public bool MayorQue(IAlumno alumX, IAlumno alumY)
        {
            return alumX.getNombre().CompareTo(alumY.getNombre()) == 1;
        }

        public bool MenorQue(IAlumno alumX, IAlumno alumY)
        {
             return alumX.getNombre().CompareTo(alumY.getNombre()) == -1;
        }
    }
}