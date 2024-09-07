using Clases.Pila;
using Funciones;
using Interfaces.PStrategy_Comparacion;


namespace Run
{
    public class Run_Ejercicio10
    {
        public static void Run()
        {
            ComparacionDni compDni = new();
           ComparacionLegajo compLegajo = new();
           ComparacionNombre compNombre = new();
           ComparacionPromedio compPromedio = new();

           Pila p = new();
           Helper.LlenarAlumnos(p);
           Helper.CambiarEstrategia(p, compDni);
           Console.WriteLine("OK");

           Helper.LlenarAlumnos(p);
           Helper.CambiarEstrategia(p, compLegajo);
           Console.WriteLine("OK");

           Helper.LlenarAlumnos(p);
           Helper.CambiarEstrategia(p, compNombre);
           Console.WriteLine("OK");

           Helper.LlenarAlumnos(p);
           Helper.CambiarEstrategia(p, compPromedio);
           Console.WriteLine("OK");
        }
    }
}