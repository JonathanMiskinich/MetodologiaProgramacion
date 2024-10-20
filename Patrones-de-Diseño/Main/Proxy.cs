using MetodologíasDeProgramaciónI;
using PFactoryMethod.StudentFactorys;

namespace Proxy
{
    public class ProxyRun
    {
        public static void Run()
        {
            Teacher profesor = new();
            StudentFactory fabrica = new();
            
            for (int i = 0; i < 10; i++)
            {
                // Con la Opcion 3 me da alumnosProxys
                Student stud = fabrica.CrearStudentDecorado("3");
                profesor.goToClass(stud);
            }

            profesor.teachingAClass();
        }
    }
}