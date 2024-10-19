using Alumnos.Comparaciones;
using Funciones;
using IColeccionable.Colas;
using IColeccionable.Conjuntos;
using IColeccionable.Diccionarios;
using IColeccionable.Pilas;

namespace Iterator
{
    public class IteratorRun
    {
        public static void Run()
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();

            Helper.LlenarAlumnos(pila, "1");
            Helper.LlenarAlumnos(cola, "1");
            Helper.LlenarAlumnos(conjunto, "1");
            Helper.LlenarAlumnos(diccionario, "1");

            Helper.ImprimirElementos(pila);
            Helper.ImprimirElementos(cola);
            Helper.ImprimirElementos(conjunto);
            Helper.ImprimirElementos(diccionario);
        }

        public static void ConStrategy()
        {
            Pila pila = new Pila();
            Helper.LlenarAlumnos(pila, "1");

            Helper.CambiarEstrategia(pila, new ComparacionCalificacion());
            Helper.Informar(pila);

            Helper.CambiarEstrategia(pila, new ComparacionDni());
            Helper.Informar(pila);

            Helper.CambiarEstrategia(pila, new ComparacionLegajo());
            Helper.Informar(pila);

            Helper.CambiarEstrategia(pila, new ComparacionNombre());
            Helper.Informar(pila);
        }
    }
}