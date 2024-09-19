using PFactoryMethod.CreadorAlumnos;
using MetodologíasDeProgramaciónI;
using Interfaces.PStrategy_Comparacion;
using PDecorator.ConcreteDecorator;
using PAdapter.alumnoAdapter;
using Interfaz.IAlumnos;
using Clases.alumnoMuyEstudioso;

namespace PFactoryMethod.StudentFactorys
{
    public class StudentFactory : CreadorAlumno
    {
        public Student CrearStudentConDecorator()
        {
            IAlumno alumno = (IAlumno)base.CrearAleatorio("1");
            alumno.setMetodoComparar(new ComparacionCalificacion());

            CalificacionLetra calificacionLetras = new CalificacionLetra(alumno);
            
            CalificacionPromocion califPromocion = new CalificacionPromocion(calificacionLetras);

            CalificacionDecorada califDecorada= new CalificacionDecorada(califPromocion);

            return new AlumnoAdapter(califDecorada);
        }
        public Student CrearStudent()
        {
            IAlumno alumno = (IAlumno)base.CrearAleatorio("1");
            alumno.setMetodoComparar(new ComparacionCalificacion());
            return new AlumnoAdapter(alumno);
        }
        public Student CrearStudentEstudioso()
        {
            AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso)base.CrearAleatorio("2");
            alumno.setMetodoComparar(new ComparacionCalificacion());
            return new AlumnoAdapter(alumno);
        }
        public Student CrearStudentEstudiosoConDecorator()
        {
            AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso)base.CrearAleatorio("2");
            alumno.setMetodoComparar(new ComparacionCalificacion());

            CalificacionLetra calificacionLetras = new CalificacionLetra(alumno);
            
            CalificacionPromocion califPromocion = new CalificacionPromocion(calificacionLetras);

            CalificacionDecorada califDecorada= new CalificacionDecorada(califPromocion);
            
            return new AlumnoAdapter(califDecorada);
        }
    }
}