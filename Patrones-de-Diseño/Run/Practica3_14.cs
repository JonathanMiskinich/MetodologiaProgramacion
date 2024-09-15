//Resolucion del ejercicio 14 de la practica 3
using Clases.Alumnos;
using Clases.Pila;
using Clases.Profesor;
using Funciones;
using PIterator;

namespace Practica3_14
{
    public class Practica_3
    {
        public static void Run()
        {
            Pila pila = new();
            Helper.LlenarAlumnos(pila);

            Profesor profesor = new("Juan", 23, 23);
            IIterator iterador = pila.CrearIterador();
            iterador.Primero();

            while(!iterador.Fin())
            {
                profesor.Suscribirse((Alumno)iterador.Actual());
                iterador.Siguiente();
            }

            //Helper.DictadoDeCLases(profesor);
        }
    }
}