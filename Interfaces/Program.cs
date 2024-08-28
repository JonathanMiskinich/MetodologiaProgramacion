using Clases.Numero;
using Clases.Pila;
using Clases.Cola;
using Interfaces_Practica1;
using Funciones;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pila pilaNueva = new Pila();
            Helper.Llenar(pilaNueva);
            Helper.Informar(pilaNueva);

            Cola colaNueva = new Cola();
            Helper.Llenar(colaNueva);
            Helper.Informar(colaNueva);
        }
    }
}