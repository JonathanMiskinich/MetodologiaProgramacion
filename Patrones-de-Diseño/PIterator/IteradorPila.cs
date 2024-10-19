using IComparable;
using Clases.Pila;

namespace PIterator
{
    public class IteradorPila : IIterator
    {
        private List<Comparable> listaIterar; 
        private int posicionActual = 0;
        
        public IteradorPila(Pila lista)
        {
            this.listaIterar = lista.GetLista;
        }

        public void Primero()
        {
            posicionActual = listaIterar.Count - 1;
        }
        public void Siguiente()
        {
            posicionActual--;
        }
        public bool Fin()
        {
            return posicionActual < 0;
        }
        public object Actual()
        {
            return listaIterar[posicionActual];
        }
    }
}