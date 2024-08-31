using Clases.Cola;
using Clases.Numero;
using PIterator;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cola conjunto = new();
            conjunto.Encolar(new Numero(33));
            conjunto.Encolar(new Numero(42));
            conjunto.Encolar(new Numero(3));

            IIterator iterador = conjunto.CrearIterador();
            iterador.Primero();

            while (!iterador.Fin())
            {
                Console.WriteLine(iterador.Actual());
                iterador.Siguiente();
            }

        }
    }
}