using Interfaces_Practica1;
using Clases.alumnoMuyEstudioso;


namespace PFactoryMethod.CreadorAlumnos
{
    public class CreadorAlumnoEstudioso : CreadorAlumno
    {

        public override Comparable CrearAleatorio(string opcion)
        {
            AlumnoMuyEstudioso alum = (AlumnoMuyEstudioso)base.CrearAleatorio(opcion);
            return alum;
        }

        public override Comparable CrearPorTeclado(string opcion)
        {
            AlumnoMuyEstudioso alum = (AlumnoMuyEstudioso)base.CrearPorTeclado(opcion);
            return alum;
        }
    }
}