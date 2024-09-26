using Interfaz.IAlumnos;
using MetodologíasDeProgramaciónI;
using PAdapter.alumnoAdapter;

namespace Clases.Aulas
{
    public class Aula
    {
        private Teacher teacher;
        public void Comenzar()
        {
            Console.WriteLine("Empezando la clase.");
            teacher = new Teacher();
        }
        public void NuevoAlumno(IAlumno alum)
        {
            Student stud = new AlumnoAdapter(alum);
            this.teacher.goToClass(stud);
        }
        public void ClaseLista()
        {
            teacher.teachingAClass();
        }
    }
}