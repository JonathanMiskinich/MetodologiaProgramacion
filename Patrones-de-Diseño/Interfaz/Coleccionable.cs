using PIterator;
using IComparable;

namespace IColeccionable
{
    public interface Coleccionable
    {
        IIterator CrearIterador();
        public int Cuantos();
        public Comparable Minimo();
        public Comparable Maximo();
        public void Agregar(Comparable elemento);
        public bool Contiene(Comparable elemento);
    }
}