using Clases.Numero;
using Clases.Pila;
using Clases.Cola;
using Clases.Persona;
using Interfaces_Practica1;
using Funciones;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pila p = new Pila();
            Helper.LlenarPersonas(p);
            Helper.Informar(p);

            Cola c = new Cola();
            Helper.LlenarPersonas(c);
            Helper.Informar(c);
        }
    }
}