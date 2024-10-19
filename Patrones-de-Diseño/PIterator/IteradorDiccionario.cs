using IComparable;
using Clases.Diccionario;
using Clases.Clave_Valor;

namespace PIterator
{
    public class IteradorDiccionario : IIterator
    {
        private List<ClaveValor> lista;
        private int posicionActual = 0;
        public IteradorDiccionario(Diccionario lista)
        {
            this.lista = lista.getLista;
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
            return lista.Count <= posicionActual;
        }
        public object Actual()
        {
            return this.lista[posicionActual];
        }
    }
}