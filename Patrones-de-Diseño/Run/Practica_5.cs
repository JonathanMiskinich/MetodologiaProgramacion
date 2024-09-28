using Clases.Aulas;
using Clases.Pila;
using Funciones;
using PCommand;

namespace Practicas
{
    public class Practica_5
    {
        public static void Run()
        {
            Aula aula = new();

            Pila pila = new();
            pila.SetOrdenInicio(new OrdenInicio(aula));
            pila.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.SetOrdenAulaLlena(new OrdenAulaLlena(aula));

            Helper.LlenarAlumnos(pila, "1");
            Helper.LlenarAlumnos(pila, "2");
        }
    }
}