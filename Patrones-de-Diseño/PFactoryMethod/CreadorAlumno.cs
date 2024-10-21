using IComparable;
using PFactoryMethod.CreadorComparables;
using ObtencionDeDatos;
using Funciones;
using IAlumnos;
using IAlumnos.Regular;
using IAlumnos.Proxy;
using IAlumnos.MuyEstudioso;
using IAlumnos.Compuesto;


namespace PFactoryMethod.CreadorAlumnos
{
    public class CreadorAlumno : ICreadorComparable
    {
        protected IObtenerDatos dato;

        public virtual Comparable CrearAleatorio(string opcion)
        {
            dato = (GeneradorDatosAzar)dato;

            int dni = dato.ObtenerNumero(10000);
            string nombre = Helper.NombreAzar();
            int legajo = dato.ObtenerNumero(10000);
            float promedio = (float)dato.ObtenerNumero(11);

            IAlumno alum = null;

            switch (opcion)
            {
                case "1":
                    alum = new Alumno(nombre,dni,legajo,promedio);
                    break;
                case "2":
                    alum = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
                    break;
                case "3":
                    alum = new AlumnoProxy(nombre,dni,legajo,promedio);
                    break;
                case "4":
                    alum = new AlumnoCompuesto();
                    break;
                default:
                    break;
            }
            return alum;
        }

        public virtual Comparable CrearPorTeclado(string opcion)
        {
            dato = (LectorDeDatos)dato;
            dato.SetManejador(new GeneradorDatosAzar());

            int dni = dato.ObtenerNumero(1000000);
            string nombre = dato.ObtenerCadena(20);
            int legajo = dato.ObtenerNumero(1000000);
            float promedio = (float)dato.ObtenerNumero(11);

            IAlumno alum = null;

            switch (opcion)
            {
                case "1":
                    alum = new Alumno(nombre,dni,legajo,promedio);
                    break;
                case "2":
                    alum = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
                    break;
                case "3":
                    alum = new AlumnoProxy(nombre,dni,legajo,promedio);
                    break;
                default:
                    break;
            }
            return alum;
        }
    }
}