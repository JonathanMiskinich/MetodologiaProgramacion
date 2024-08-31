using Clases.Alumno;
using Interfaces.PStrategy_Comparacion;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno("Juan", 1,1,10);
            a.setMetodoComparar(new ComparacionPromedio());

            Alumno alum2 = new("Pablo", 10,1,10);

            Console.WriteLine("Comparacion por promedio: " + a.Comparacion(alum2));

            a.setMetodoComparar(new ComparacionDni());
            Console.WriteLine("Comparacion por DNi: " + a.Comparacion(alum2));

            a.setMetodoComparar(new ComparacionNombre());
            Console.WriteLine("Comparacion por Nombre: " + a.Comparacion(alum2));

            a.setMetodoComparar(new ComparacionLegajo());
            Console.WriteLine("Comparacion por Legajo: " + a.Comparacion(alum2));

        }
    }
}