using IComparable;
using IColeccionable.Conjuntos;

namespace PIterator.Conjuntos
{
    public class IteradorConjunto : IIterator
    {
        private List<Comparable> listaIterar; 
        private sbyte posicionActual = 0;
        public IteradorConjunto(Conjunto lista)
        {
            this.listaIterar = lista.GetLista;
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