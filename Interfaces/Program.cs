using Clases.Pila;
using Clases.Cola;
using Funciones;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pila p = new Pila();
            Helper.LlenarAlumnos(p);
            Helper.Informar(p);

            Cola c = new Cola();
            Helper.LlenarAlumnos(c);
            Helper.Informar(c);
        }
    }
}