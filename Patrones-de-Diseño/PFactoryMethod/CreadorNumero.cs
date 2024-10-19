using IComparable;
using PFactoryMethod.CreadorComparables;
using Clases.DatosAzar;
using Clases.LectorDeDatos;
using Funciones;
using IComparable.Numero;

namespace PFactoryMethod.CreadorNumero
{
    public class CreadorNumero : ICreadorComparable
    {
        public Comparable CrearAleatorio(string opcion)
        {
            return new Numero((sbyte)GeneradorDatosAzar.NumeroAleatorio(128));
        }

        public Comparable CrearPorTeclado(string opcion)
        {
            return new Numero((sbyte)LectorDeDatos.NumeroPorTeclado());
        }
    }
}