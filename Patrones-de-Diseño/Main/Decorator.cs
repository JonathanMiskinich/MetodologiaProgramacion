using MetodologíasDeProgramaciónI;
using PFactoryMethod.StudentFactorys;

namespace Decorator
{
    public class PDecoratorRun
    {
        public static void Run()
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