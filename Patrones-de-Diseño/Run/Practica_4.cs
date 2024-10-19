using MetodologíasDeProgramaciónI;
using Clases.alumnoMuyEstudioso;
using PAdapter.alumnoAdapter;
using PDecorator.ConcreteDecorator;
using Interfaz.IAlumnos;
using PFactoryMethod.CreadorAlumnos;
using PFactoryMethod.StudentFactorys;
using Alumnos.Comparaciones;

namespace Practica_n4
{
    public class Practica_4
    {
        public static void FormarClase()
        {
            Teacher profesor = new();
            StudentFactory fabrica = new();
            
            for (int i = 0; i < 10; i++)
            {
                Student stud = fabrica.CrearStudent("1");
                profesor.goToClass(stud);
            }
            
            for (int i = 0; i < 10; i++)
            {
                Student stud = fabrica.CrearStudent("2");
                profesor.goToClass(stud);
            }

            profesor.teachingAClass();
        }
        public static void StudentConDecorator()
        {
            Teacher profesor = new();
            StudentFactory fabrica = new();
            
            for (int i = 0; i < 10; i++)
            {
                Student stud = fabrica.CrearStudentDecorado("1");
                profesor.goToClass(stud);
            }
            
            for (int i = 0; i < 10; i++)
            {
                Student stud = fabrica.CrearStudentDecorado("2");
                profesor.goToClass(stud);
            }
            
            profesor.teachingAClass();
        }
    }
}