using Interfaces_Practica1;

namespace PFactoryMethod.CreadorComparables
{
    public interface ICreadorComparable
    {
        public Comparable CrearAleatorio(string opcion);
        public Comparable CrearPorTeclado(string opcion);
    }
}