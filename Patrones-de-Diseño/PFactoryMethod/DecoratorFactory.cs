using IComparable;
using PFactoryMethod.CreadorAlumnos;
using IAlumnos;
using PDecorator.ConcreteDecorator;
using ObtencionDeDatos;

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
            IAlumno alumno = (IAlumno)base.Crear(opcionAlumno, GeneradorDatosAzar.GetInstancia());
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
            LectorDeDatos lector = new();
            lector.SetManejador(GeneradorDatosAzar.GetInstancia());

            IAlumno alumno = (IAlumno)base.Crear(opcionAlumno, lector);
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