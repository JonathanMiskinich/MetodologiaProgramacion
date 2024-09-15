using Clases.Alumnos;

namespace Interfaces.PStrategy_Comparacion
{
    public class ComparacionDni : Comparacion
    {
        public bool ComparacionIguales(Alumno alumX, Alumno alumY)
        {
            return alumX.getDni == alumY.getDni;
        }
    }
}