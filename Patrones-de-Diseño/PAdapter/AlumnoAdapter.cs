using MetodologíasDeProgramaciónI;
using Clases.Alumnos;

namespace PAdapter.alumnoAdapter
{
    public class AlumnoAdapter : Student
    {
        private Alumno alum = null;

        public AlumnoAdapter(Alumno alumno)
        {
            this.alum = alumno;
        }

        public string getName()
        {
            return alum.getNombre;
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
            return string.Compare(this.getName(), student.getName()) == 1;
        }

		public bool greaterThan(Student student)
        {
            return string.Compare(this.getName(), student.getName()) == -1;
        }

    }
}