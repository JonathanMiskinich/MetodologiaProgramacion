using IAlumnos.Regular;

namespace IAlumnos.MuyEstudioso
{
    public class AlumnoMuyEstudioso : Alumno, IAlumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, float promedio) : base(nombre, dni, legajo, promedio){}
        public override int ResponderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}