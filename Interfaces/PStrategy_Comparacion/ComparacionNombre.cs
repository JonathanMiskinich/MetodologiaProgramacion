using Clases.Alumno;

namespace Interfaces.PStrategy_Comparacion
{
    public class ComparacionNombre : Comparacion
    {
        public bool ComparacionIguales(Alumno alumX, Alumno alumY)
        {
            return alumX.getNombre == alumY.getNombre;
        }
    }
}