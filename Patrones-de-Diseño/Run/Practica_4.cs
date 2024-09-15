using MetodologíasDeProgramaciónI;
using Clases.alumnoMuyEstudioso;
using Clases.Alumnos;
using PAdapter.alumnoAdapter;
using Funciones;
using Clases.DatosAzar;

namespace Practica_n4
{
    public class Practica_4
    {
        public static void Ejercicio_4()
        {
            Teacher profesor = new();
            
            for (int i = 0; i < 10; i++)
            {
                Alumno alumno = new Alumno(Helper.NombreAzar(), GeneradorDatosAzar.NumeroAleatorio(10000), GeneradorDatosAzar.NumeroAleatorio(10000), (float)i);
                AlumnoAdapter studentAdaptado = new AlumnoAdapter(alumno);
                profesor.goToClass(studentAdaptado);
            }
            
            for (int i = 0; i < 10; i++)
            {
                AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso(Helper.NombreAzar(), GeneradorDatosAzar.NumeroAleatorio(10000), GeneradorDatosAzar.NumeroAleatorio(10000), (float)i);
                AlumnoAdapter studentAdaptado = new AlumnoAdapter(alumno);
                profesor.goToClass(studentAdaptado);
            }

            profesor.teachingAClass();
        }
    }
}