using Interfaces_Practica1;
using PFactoryMethod.CreadorAlumnos;
using IAlumnos;
using PDecorator.ConcreteDecorator;

namespace PFactoryMethod.DecoratorFactorys
{
    public class DecoratorFactory : CreadorAlumno
    {
        public IAlumno CrearDecorator(IAlumno alumno, string opcionDecorator)
        {
            IAlumno decorador = null;

            switch (opcionDecorator)
            {
                case "1":
                    decorador = new CalificacionLetra(alumno);
                    break;
                case "2":
                    decorador = new CalificacionLegajo(alumno);
                    break;
                case "3":
                    decorador = new CalificacionPromocion(alumno);
                    break;
                case "4":
                    decorador = new CalificacionDecorada(alumno);
                    break;
                default:
                    break;
            }
            return decorador;
        }
        public IAlumno CrearDecoratorAleatorio(string opcionDecorator, string opcionAlumno)
        {
            IAlumno alumno = (IAlumno)base.CrearAleatorio(opcionAlumno);
            IAlumno decorador = null;

            switch (opcionDecorator)
            {
                case "1":
                    decorador = new CalificacionLetra(alumno);
                    break;
                case "2":
                    decorador = new CalificacionLegajo(alumno);
                    break;
                case "3":
                    decorador = new CalificacionPromocion(alumno);
                    break;
                case "4":
                    decorador = new CalificacionDecorada(alumno);
                    break;
                default:
                    break;
            }
            return decorador;
        }

        public Comparable CrearDecoratorPorTeclado(string opcionAlumno, string opcionDecorator)
        {
            IAlumno alumno = (IAlumno)base.CrearPorTeclado(opcionAlumno);
            IAlumno decorador = null;

            switch (opcionDecorator)
            {
                case "1":
                    decorador = new CalificacionLetra(alumno);
                    break;
                case "2":
                    decorador = new CalificacionLegajo(alumno);
                    break;
                case "3":
                    decorador = new CalificacionPromocion(alumno);
                    break;
                case "4":
                    decorador = new CalificacionDecorada(alumno);
                    break;
                default:
                    break;
            }
            return decorador;
        }
    }
}