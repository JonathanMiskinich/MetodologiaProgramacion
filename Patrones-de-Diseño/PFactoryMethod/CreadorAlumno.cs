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
        protected GeneradorDatosAzar datoAleatorio = new();
        protected LectorDeDatos datoTeclado = new();


        public virtual Comparable CrearAleatorio(string opcion)
        {
            int dni = datoAleatorio.ObtenerNumero(10000);
            string nombre = Helper.NombreAzar();
            int legajo = datoAleatorio.ObtenerNumero(10000);
            float promedio = (float)datoAleatorio.ObtenerNumero(11);

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
            int dni = datoTeclado.ObtenerNumero(1000000);
            string nombre = datoTeclado.ObtenerCadena(20);
            int legajo = datoTeclado.ObtenerNumero(1000000);
            float promedio = (float)datoTeclado.ObtenerNumero(11);

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