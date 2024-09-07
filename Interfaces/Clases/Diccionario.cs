using Clases.Clave_Valor;
using Interfaces_Practica1;
using PIterator;

namespace Clases.Diccionario
{
    public class Diccionario : Coleccionable
    {
        private List<ClaveValor> listaElementos;
        //Utilizo Clase Numero por que necesito qeu la clave sea Comparable
        private static Numero.Numero claveUnica = new Numero.Numero(0);
        //Constructores
        public Diccionario()
        {
            listaElementos = new List<ClaveValor>();
        }

        // getters and setters
        public List<ClaveValor> getLista
        {
            get { return this.listaElementos; }
        }
        //iterador
        public IIterator CrearIterador()
        {
            return new IteradorDiccionario(this);
        }
        //Metodos de la clase
        public void Agregar(Comparable clave, object valor)
        {
            foreach (ClaveValor item in listaElementos)
            {
                if (item.sosIgual(clave))
                {
                    item.setValue(valor);
                    return;
                }
            }

            ClaveValor elementoAgregar = new ClaveValor(clave, valor);
            this.listaElementos.Add(elementoAgregar);
        }
        public object ValorDe(Comparable clave)
        {
            foreach (ClaveValor item in listaElementos)
            {
                if (item.sosIgual(clave))
                    return item.getValue;
            }

            return null;
        }

        //Metodos de la interfaz
        public int Cuantos()
        {
            return this.listaElementos.Count;
        }
        public Comparable Minimo()
        {
            object minimo = null;
            foreach (ClaveValor item in listaElementos)
            {
                if (minimo == null)
                    minimo = item.getValue;
                else
                {
                    if (item.getValue is IComparable value1 && minimo is IComparable value2)
                    {
                        if (value1.CompareTo(value2) < 0)
                            minimo = item.getValue;
                    }
                        
                }
            }

            return (Comparable)minimo;
        }
        public Comparable Maximo()
        {
            object maximo = null;
            foreach (ClaveValor item in listaElementos)
            {
                if (maximo == null)
                    maximo = item.getValue;
                else
                {
                    if (item.getValue is IComparable value1 && maximo is IComparable value2)
                    {
                        if (value1.CompareTo(value2) > 0)
                            maximo = item.getValue;
                    }
                }
            }

            return (Comparable)maximo;
        }
        public void Agregar(Comparable elemento)
        {
            ClaveValor elemAgregar = new(claveUnica, elemento);
            claveUnica.SetValor = claveUnica.VALOR++;
            listaElementos.Add(elemAgregar);
        }
        public bool Contiene(Comparable elemento)
        {
            foreach (ClaveValor item in listaElementos)
            {
                if (item.getValue is IComparable value1 && elemento is IComparable value2)
                    {
                        if (value1.CompareTo(value2) == 0)
                            return true;
                    }
            }
            return false;
        }
    }
}