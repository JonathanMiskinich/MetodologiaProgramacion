using Clases.Alumnos;
using Funciones;
using Interfaz.IAlumnos;
using PFactoryMethod.DecoratorFactorys;

namespace Practicas
{
    public class Practica_5
    {
        public static void Run()
        {
            AlumnoProxy alum = new AlumnoProxy(Helper.NombreAzar(), new Random().Next(10000), new Random().Next(10000), 0);
            DecoratorFactory fabricaDecoradores = new DecoratorFactory();
            IAlumno decorator = fabricaDecoradores.CrearDecorator(alum, "1");
            Console.WriteLine(decorator.MostrarCalificacion());
        }
    }
}