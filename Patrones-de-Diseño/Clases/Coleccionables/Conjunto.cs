using IComparable;
using PCommand;
using PIterator.Conjuntos;
using PIterator;

namespace IColeccionable.Conjuntos
{
    public class Conjunto : Coleccionable, Ordenable
    {
        List<Comparable> elementos;
        private OrdenEnAula1 Inicio;
        private OrdenEnAula1 AulaLlena;
        private OrdenEnAula2 LlegaAlumno;
        public Conjunto()
        {
            elementos = new List<Comparable>();
        }
        // Getters and setters
        public List<Comparable> GetLista { get{return this.elementos; } }
        // Iterador
        public IIterator CrearIterador()
        {
            return new IteradorConjunto(this);
        }
        public int Cuantos()
        {
            return elementos.Count;
        }
        public Comparable Minimo()
        {
            Comparable valorMinimo = null;
            foreach (Comparable item in this.elementos)
            {
                if (valorMinimo == null)
                    valorMinimo = item;
                else
                {
                    if (valorMinimo.sosMenor(item))
                        valorMinimo = item;
                }
            }

            return valorMinimo;
        }
        public Comparable Maximo()
        {
            Comparable valorMaximo = null;
            foreach (Comparable item in elementos)
            {
                if (valorMaximo == null)
                    valorMaximo = item;
                else
                {
                    if (valorMaximo.sosMayor(item))
                        valorMaximo = item;
                }
            }

            return valorMaximo;
        }
        public void Agregar(Comparable elemento)
        {
            if (!this.Contiene(elemento))
            {
                if(this.Cuantos() == 0)
                    this.Inicio.Ejecutar();
   
                else if(Cuantos() == 39)
                    this.AulaLlena.Ejecutar();
                    
                this.LlegaAlumno.Ejecutar(elemento);
                elementos.Add(elemento);
            }
        }
        public bool Contiene(Comparable elemento)
        {
            return elementos.Contains(elemento);
        }

        public void SetOrdenInicio(OrdenEnAula1 orden)
        {
            this.Inicio = orden;
        }

        public void SetOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this.LlegaAlumno = orden;
        }

        public void SetOrdenAulaLlena(OrdenEnAula1 orden)
        {
            this.AulaLlena = orden;
        }
    }
}