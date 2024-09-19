using Clases.Alumnos;
using Interfaz.IAlumnos;

namespace Interfaces.PStrategy_Comparacion
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