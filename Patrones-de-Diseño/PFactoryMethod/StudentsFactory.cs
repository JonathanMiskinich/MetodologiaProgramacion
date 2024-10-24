using PFactoryMethod.CreadorAlumnos;
using MetodologíasDeProgramaciónI;
using PDecorator.ConcreteDecorator;
using PAdapter.alumnoAdapter;
using IAlumnos;
using  PFactoryMethod.DecoratorFactorys;
using ObtencionDeDatos;

namespace PFactoryMethod.StudentFactorys
{
    public class StudentFactory : CreadorAlumno
    {
        public Student CrearStudent(string opcion)
        {
            IAlumno alumno = (IAlumno)base.Crear(opcion, GeneradorDatosAzar.GetInstancia());
            Student stud = new AlumnoAdapter(alumno);
            return stud;
        }
        public Student CrearStudentDecorado(string opcion)
        {
            DecoratorFactory fabricaDecoradores = new();
            IAlumno decorador = fabricaDecoradores.CrearDecoratorAleatorio("1", opcion);
            decorador = fabricaDecoradores.CrearDecorator(decorador, "2"); 
            decorador = fabricaDecoradores.CrearDecorator(decorador, "3"); 
            decorador = fabricaDecoradores.CrearDecorator(decorador, "4"); 

            Student stud = new AlumnoAdapter(decorador);
            return stud;
        }
    }
}