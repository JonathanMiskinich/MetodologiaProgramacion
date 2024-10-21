using IComparable;
using PFactoryMethod.CreadorComparables;
using ObtencionDeDatos;
using Funciones;
using IComparable.Numero;

namespace PFactoryMethod.CreadorNumero
{
    public class CreadorNumero : ICreadorComparable
    {
        public Comparable CrearAleatorio(string opcion)
        {
            GeneradorDatosAzar dato = new();
            return new Numero((sbyte)dato.ObtenerNumero(128));
        }

        public Comparable CrearPorTeclado(string opcion)
        {
            LectorDeDatos dato = new();
            return new Numero((sbyte)dato.ObtenerNumero(128));
        }
    }
}