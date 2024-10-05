using Clases.Aulas;
using Clases.Pila;
using Funciones;
using MetodologíasDeProgramaciónI;
using PCommand;
using PFactoryMethod.StudentFactorys;

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

        public static void FormarClaseConProxy()
        {
            Teacher profesor = new();
            StudentFactory fabrica = new();
            
            for (int i = 0; i < 10; i++)
            {
                Student stud = fabrica.CrearStudentDecorado("3");
                profesor.goToClass(stud);
            }

            profesor.teachingAClass();
        }
    }
}