using System.Dynamic;
using Interfaces_Practica1;
using PCommand;
using PIterator;

namespace Clases.Conjunto
{
    public class Conjunto : Coleccionable, Ordenable
    {
        List<Comparable> elementos;
        private OrdenEnAula1 orden1;
        private OrdenEnAula2 orden2;
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
                elementos.Add(elemento);
            }
        }
        public bool Contiene(Comparable elemento)
        {
            return elementos.Contains(elemento);
        }

        public void SetOrdenInicio(OrdenEnAula1 orden)
        {
            this.orden1 = orden;
        }

        public void SetOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this.orden2 = orden;
        }

        public void SetOrdenAulaLlena(OrdenEnAula1 orden)
        {
            this.orden1 = orden;
        }
    }
}