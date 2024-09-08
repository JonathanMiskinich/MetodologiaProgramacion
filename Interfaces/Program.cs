using Clases.LectorDeDatos;
using PCreadorComparables;
using PCreadorNumero;
using PCreadorAlumnos;
using Clases.Numero;
using Clases.Alumno;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComparableFactory numeroFactory = new CreadorNumero();
            ComparableFactory alumnoFactory = new CreadorAlumno();

            Numero num = (Numero)numeroFactory.CreadorComparable();
            Alumno alum = (Alumno)alumnoFactory.CreadorComparable();

            Console.WriteLine(alum.ToString());
        }
    }
}