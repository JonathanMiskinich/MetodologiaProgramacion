using IComparable;
using ObtencionDeDatos;

namespace PFactoryMethod.CreadorComparables
{
    public interface ICreadorComparable
    {
        public Comparable Crear(string opcion, IObtenerDatos datoGenerador);
    }
}