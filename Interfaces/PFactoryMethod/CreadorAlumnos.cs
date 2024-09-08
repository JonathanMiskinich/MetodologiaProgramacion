using Interfaces_Practica1;
using PCreadorComparables;
using Clases.DatosAzar;
using Clases.Alumno;

namespace PCreadorAlumnos
{
    public class CreadorAlumno : ComparableFactory
    {
        public override Comparable CreadorComparable()
        {
            return new Alumno(GeneradorDatosAzar.StringAleatorio(5), GeneradorDatosAzar.NumeroAleatorio(10), GeneradorDatosAzar.NumeroAleatorio(1000), 0);
        }
    }
}