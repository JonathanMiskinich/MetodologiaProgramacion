using Clases.Aulas;
using Funciones;
using IColeccionable.Pilas;

namespace PCommand
{
    public class CommandRun
    {
        public static void Run()
        {
            Pila pila = new Pila();
            Aula aula = new Aula();

            pila.SetOrdenInicio(new OrdenInicio(aula));
            pila.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.SetOrdenAulaLlena(new OrdenAulaLlena(aula));

            Helper.LlenarAlumnos(pila, "1");
            Helper.LlenarAlumnos(pila, "2");
        }
    }
}