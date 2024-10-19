using Alumnos;
using IAlumnos;
using MetodologíasDeProgramaciónI;
using PAdapter.alumnoAdapter;
using PFactoryMethod.CreadorAlumnos;
using PFactoryMethod.StudentFactorys;

namespace Practicas
{
    public class Practica_6
    {
        public static void ClaseConCompuesto()
        {
            Teacher profesor = new();
            StudentFactory fabrica = new();
            
            for (int i = 0; i < 10; i++)
            {
                Student stud = fabrica.CrearStudentDecorado("3");
                profesor.goToClass(stud);
            }

            AlumnoCompuesto alumnoComp = new();
            CreadorAlumno fabricaAlum = new();

            for (int i = 0; i < 5; i++)
            {
                IAlumno alum = (IAlumno)fabricaAlum.CrearAleatorio("1");
                alumnoComp.AgregarHijo(alum);
            }
            Student student = new AlumnoAdapter(alumnoComp);
            profesor.goToClass(student);

            profesor.teachingAClass();
        }
    }
}