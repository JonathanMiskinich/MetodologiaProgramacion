using Clases.DatosAzar;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
        

        string mensaje = GeneradorDatosAzar.StringAleatorio(10);
        Console.WriteLine(mensaje);
        }
    }
}