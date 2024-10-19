using IComparable;
using IColeccionable.Colas;

namespace PIterator.Colas
{
    public class IteradorCola : IIterator
    {
        private List<Comparable> listaIterar; 
        private int posicionActual = 0;
        public IteradorCola(Cola lista)
        {
            this.listaIterar = lista.GetCola;
        }

        public void Primero()
        {
            posicionActual = 0;
        }
        public void Siguiente()
        {
            posicionActual++;
        }
        public bool Fin()
        {
            return listaIterar.Count <= posicionActual;
        }
        public object Actual()
        {
            return listaIterar[posicionActual];
        }
    }
}