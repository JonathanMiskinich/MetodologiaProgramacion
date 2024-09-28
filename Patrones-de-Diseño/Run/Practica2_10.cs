//Resolucion del ejercicio 10 de la practica 2.
using Clases.Pila;
using Funciones;
using Interfaces.PStrategy_Comparacion;

namespace Practica2_10
{
    public class Practica_2
    {
        public static void Run()
        {
            ComparacionDni compDni = new();
           ComparacionLegajo compLegajo = new();
           ComparacionNombre compNombre = new();
           ComparacionPromedio compPromedio = new();

           Pila p = new();
           Helper.LlenarAlumnos(p, "1");
           Helper.CambiarEstrategia(p, compDni);
           Console.WriteLine("OK");

           Helper.LlenarAlumnos(p, "1");
           Helper.CambiarEstrategia(p, compLegajo);
           Console.WriteLine("OK");

           Helper.LlenarAlumnos(p, "1");
           Helper.CambiarEstrategia(p, compNombre);
           Console.WriteLine("OK");

           Helper.LlenarAlumnos(p, "1");
           Helper.CambiarEstrategia(p, compPromedio);
           Console.WriteLine("OK");
        }
    }
}