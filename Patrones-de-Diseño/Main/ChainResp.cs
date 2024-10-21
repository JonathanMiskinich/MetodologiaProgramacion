using ObtencionDeDatos;

namespace PChainOfResponsability
{
    public class ChainRun
    {
        // Muestra el dato por pantalla o uno aleatorio en caso de no cumplir con ciertas condiciones
        public static void Run()
        {
            LectorDeDatos lector = new();
            GeneradorDatosAzar datosAzar = new();

            lector.SetManejador(datosAzar);

            Console.Write("Ingrese un numero:");
            Console.WriteLine(lector.ObtenerNumero(100));

            Console.WriteLine("Ingrese un texto cualquiera: ");
            Console.WriteLine(lector.ObtenerCadena(10));
        }
    }
}