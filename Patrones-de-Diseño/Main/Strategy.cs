using IAlumnos.Regular;
using PFactoryMethod.CreadorAlumnos;
using Alumnos.Comparaciones;
using ObtencionDeDatos;

namespace Strategy
{
    public class StrategyRun
    {
        public static void Run()
        {
            // Practica 2
            CreadorAlumno fabrica = new();
            Alumno alum = (Alumno)fabrica.Crear("1",GeneradorDatosAzar.GetInstancia());
            Alumno alum2 = (Alumno)fabrica.Crear("1", GeneradorDatosAzar.GetInstancia());

            alum.setMetodoComparar(new ComparacionCalificacion());
            alum2.setMetodoComparar(new ComparacionCalificacion());

            Console.WriteLine(alum.sosIgual(alum2));
        }
    }
}