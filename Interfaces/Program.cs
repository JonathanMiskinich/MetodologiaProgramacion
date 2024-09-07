using Clases.LectorDeDatos;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LectorDeDatos.NumeroPorTeclado());
            Console.WriteLine(LectorDeDatos.StringPorTeclado());
        }
    }
}