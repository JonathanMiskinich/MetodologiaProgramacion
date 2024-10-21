using IComparable;
using PFactoryMethod.CreadorComparables;
using ObtencionDeDatos;
using Funciones;
using IComparable.Numero;

namespace PFactoryMethod.CreadorNumero
{
    public class CreadorNumero : ICreadorComparable
    {
        protected IObtenerDatos dato;

        public Comparable Crear(string opcion, IObtenerDatos datoGenerador)
        {
            return new Numero((sbyte)datoGenerador.ObtenerNumero(128));
        }
    }
}