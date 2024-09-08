using Clases.Profesor;
using Clases.Alumno;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Profesor p = new("Juna", 23, 2);
            Alumno alum = new("pablo", 33, 322, 9);
            Alumno alum2 = new("Pedro", 2323, 22, 7);
            Alumno alum3 = new("Julia", 2222, 444, 3);

            p.Suscribirse(alum);
            p.Suscribirse(alum2);
            p.Suscribirse(alum3);

            p.HablarALaClase();
            p.EscribirEnElPizarron();
        }
    }
}