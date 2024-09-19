using PFactoryMethod.CreadorAlumnos;
using MetodologíasDeProgramaciónI;
using PDecorator.ConcreteDecorator;
using PAdapter.alumnoAdapter;
using Interfaz.IAlumnos;

namespace PFactoryMethod.StudentFactorys
{
    public class StudentFactory : CreadorAlumno
    {
        public Student CrearStudent(string opcion)
        {
            IAlumno alumno = (IAlumno)base.CrearAleatorio(opcion);
            Student stud = new AlumnoAdapter(alumno);
            return stud;
        }
        public Student CrearStudentDecorado(string opcion)
        {
            IAlumno alumno = (IAlumno)base.CrearAleatorio(opcion);
            
            CalificacionLegajo decoradorLegajo = new CalificacionLegajo(alumno);
            CalificacionLetra decoradoLetras = new CalificacionLetra(decoradorLegajo);
            CalificacionPromocion decoradoPromocion = new(decoradoLetras);
            CalificacionDecorada decoradaAsteriscos = new(decoradoPromocion);

            Student stud = new AlumnoAdapter(decoradaAsteriscos);
            return stud;
        }
    }
}