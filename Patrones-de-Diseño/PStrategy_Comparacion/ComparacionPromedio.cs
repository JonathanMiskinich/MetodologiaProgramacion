using Clases.Alumno;

namespace Interfaces.PStrategy_Comparacion
{
    public class ComparacionPromedio : Comparacion
    {
        public bool ComparacionIguales(Alumno alumX, Alumno alumY)
        {
            return alumX.getPromedio == alumY.getPromedio;
        }
    }
}