using Clases.Diccionario;
using Funciones;
using Clases.Cola;
using Clases.Pila;
using Clases.Conjunto;
using Interfaces.PStrategy_Comparacion;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
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