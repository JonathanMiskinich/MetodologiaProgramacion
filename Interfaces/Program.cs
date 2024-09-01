using Clases.Diccionario;
using Clases.Numero;
using Clases.Clave_Valor;
using PIterator;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Diccionario conjunto = new();
            conjunto.Agregar(new Numero(34), "HOla");
            conjunto.Agregar(new Numero(2), "Juan");
            conjunto.Agregar(new Numero(12), "Muerte");
            conjunto.Agregar(new Numero(34), "Boquita");

            IIterator iterador = conjunto.CrearIterador();
            iterador.Primero();

            while (!iterador.Fin())
            {
                Console.WriteLine(iterador.Actual().ToString());
                iterador.Siguiente();
            }

        }
    }
}