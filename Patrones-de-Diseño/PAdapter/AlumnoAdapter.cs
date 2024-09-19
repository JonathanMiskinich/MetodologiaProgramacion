using MetodologíasDeProgramaciónI;
using Interfaz.IAlumnos;


namespace PAdapter.alumnoAdapter
{
    public class AlumnoAdapter : Student
    {
        private IAlumno alum = null;

        public AlumnoAdapter(IAlumno alumno)
        {
            this.alum = alumno;
        }

        public string getName()
        {
            return alum.getNombre();
        }
		public int yourAnswerIs(int question)
        {
            return alum.ResponderPregunta(question);
        }
		public void setScore(int score)
        {
            alum.setCalificacion(score);
        }
		public string showResult()
        {
            return alum.MostrarCalificacion();
        }
		public bool equals(Student student)
        {
            return this.getName() == student.getName();
        }
		public bool lessThan(Student student)
        {
            return this.getName().CompareTo(student.getName()) > 0;
        }

		public bool greaterThan(Student student)
        {
            return this.getName().CompareTo(student.getName()) < 0;
        }

    }
}