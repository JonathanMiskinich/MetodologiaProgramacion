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
    }
}