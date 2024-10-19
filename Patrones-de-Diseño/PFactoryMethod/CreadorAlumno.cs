using Interfaces_Practica1;
using PFactoryMethod.CreadorComparables;
using Clases.DatosAzar;
using Clases.LectorDeDatos;
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

        public virtual Comparable CrearAleatorio(string opcion)
        {
            int dni = GeneradorDatosAzar.NumeroAleatorio(10000);
            string nombre = Helper.NombreAzar();
            int legajo = GeneradorDatosAzar.NumeroAleatorio(10000);
            float promedio = (float)GeneradorDatosAzar.NumeroAleatorio(11);

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
            int dni = LectorDeDatos.NumeroPorTeclado();
            string nombre = LectorDeDatos.StringPorTeclado();
            int legajo = LectorDeDatos.NumeroPorTeclado();
            float promedio = (float)LectorDeDatos.NumeroPorTeclado();

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