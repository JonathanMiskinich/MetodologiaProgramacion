using IComparable;

namespace PFactoryMethod.CreadorComparables
{
    public interface ICreadorComparable
    {
        public Comparable CrearAleatorio(string opcion);
        public Comparable CrearPorTeclado(string opcion);
        public Comparable CrearPorArchivo(string opcion);
    }
}