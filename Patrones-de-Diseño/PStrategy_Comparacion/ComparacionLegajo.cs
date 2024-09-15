using Clases.Alumnos;

namespace Interfaces.PStrategy_Comparacion
{
    public class ComparacionLegajo : Comparacion
    {
        public bool ComparacionIguales(Alumno alumX, Alumno alumY)
        {
            return alumX.getLegajo == alumY.getLegajo;
        }
    }
}