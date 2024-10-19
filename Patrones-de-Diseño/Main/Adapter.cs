using MetodologíasDeProgramaciónI;
using PFactoryMethod.StudentFactorys;

namespace PAdapter
{
    public class AdapterRun
    {
        public static void Run()
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
    }
}