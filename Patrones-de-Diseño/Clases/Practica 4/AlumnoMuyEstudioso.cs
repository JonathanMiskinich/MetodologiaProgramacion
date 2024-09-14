using Clases.Alumno;

namespace Clases.alumnoMuyEstudioso
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public override int ResponderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}