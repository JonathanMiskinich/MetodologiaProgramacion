using Interfaces_Practica1;
using PFactoryMethod.CreadorComparables;
using Clases.DatosAzar;
using Clases.LectorDeDatos;
using Funciones;
using Clases.Alumnos;

namespace PFactoryMethod.CreadorAlumno
{
    public class CreadorAlumno : ICreadorComparable
    {

        public  Comparable CrearAleatorio()
        {
            int dni = GeneradorDatosAzar.NumeroAleatorio(10000);
            string nombre = Helper.NombreAzar();
            int legajo = GeneradorDatosAzar.NumeroAleatorio(10000);
            float promedio = (float)GeneradorDatosAzar.NumeroAleatorio(10000);

            Alumno alum = new(nombre, dni, legajo, promedio);
            return alum;
        }

        public Comparable CrearPorTeclado()
        {
            int dni = LectorDeDatos.NumeroPorTeclado();
            string nombre = LectorDeDatos.StringPorTeclado();
            int legajo = LectorDeDatos.NumeroPorTeclado();
            float promedio = (float)LectorDeDatos.NumeroPorTeclado();

            Alumno alum = new(nombre, dni, legajo, promedio);
            return alum;
        }
    }
}