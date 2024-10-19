using Alumnos.Comparaciones;
using Interfaces_Practica1;
using IAlumnos;
using Clases.Alumnos;

namespace Clases.alumnoMuyEstudioso
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