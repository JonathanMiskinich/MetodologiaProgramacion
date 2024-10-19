using Clases.Profesor;
using Funciones;
using IAlumnos.Regular;
using IColeccionable.Pilas;
using PIterator;

namespace PObserver
{
    public class ObserverRun
    {
        public static void Run()
        {
            Pila pila = new();
            Helper.LlenarAlumnos(pila, "1");

            Profesor profesor = new("Juan", 23, 23);
            IIterator iterador = pila.CrearIterador();
            iterador.Primero();

            while(!iterador.Fin())
            {
                profesor.Suscribirse((Alumno)iterador.Actual());
                iterador.Siguiente();
            }

            Helper.DictadoDeCLases(profesor);
        }
    }
}