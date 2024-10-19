using IAlumnos.Regular;
using PFactoryMethod.CreadorAlumnos;
using Alumnos.Comparaciones;

namespace Strategy
{
    public class StrategyRun
    {
        public static void Run()
        {
            // Practica 2
            CreadorAlumno fabrica = new();
            Alumno alum = (Alumno)fabrica.CrearAleatorio("1");
            Alumno alum2 = (Alumno)fabrica.CrearAleatorio("1");

            alum.setMetodoComparar(new ComparacionCalificacion());
            alum2.setMetodoComparar(new ComparacionCalificacion());

            Console.WriteLine(alum.sosIgual(alum2));
        }
    }
}