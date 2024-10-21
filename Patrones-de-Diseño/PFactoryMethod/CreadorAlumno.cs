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

        //En un futuro unico metodo de la fabrica
        public virtual Comparable Crear(string opcion, IObtenerDatos datoGenerador)
        {
            int dni = datoGenerador.ObtenerNumero(10000);
            string nombre = Helper.NombreAzar();
            int legajo = datoGenerador.ObtenerNumero(10000);
            float promedio = (float)datoGenerador.ObtenerNumero(11);

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

        public virtual Comparable CrearAleatorio(string opcion)
        {
            GeneradorDatosAzar dato = new();

            int dni = 0;
            string nombre = "";
            int legajo = 0;
            float promedio = 0;

            if (dato != null)
            {
                dni = dato.ObtenerNumero(10000);
                nombre = Helper.NombreAzar();
                legajo = dato.ObtenerNumero(10000);
                promedio = (float)dato.ObtenerNumero(11);
            }

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

        public Comparable CrearPorArchivo(string opcion)
        {
            dato = (LectorDeArchivos)dato;
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