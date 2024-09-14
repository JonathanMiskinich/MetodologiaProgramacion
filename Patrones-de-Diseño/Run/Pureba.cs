using PFactoryMethod.CreadorComparables;
using PFactoryMethod.CreadorAlumno;
using Clases.Alumno;

namespace Run.Prueba
{
    public class Pruebas
    {
        public static void Run()
        {
            ICreadorComparable fabricaAlumno = new CreadorAlumno();
            Alumno alumno = (Alumno)fabricaAlumno.CrearAleatorio();
        }
    }
}