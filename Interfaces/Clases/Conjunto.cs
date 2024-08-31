using Interfaces_Practica1;

namespace Clases.Conjunto
{
    public class Conjunto : Coleccionable
    {
        List<Comparable> elementos;
        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        public int Cuantos()
        {
            return elementos.Count;
        }
        public Comparable Minimo()
        {
            Comparable valorMinimo = null;
            foreach (Comparable item in this.elementosCola)
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
            Comparable valorMaximo = null
            foreach (Comparable item in elementos)
            {
                if (valorMaximo == null)
                    valorMaximo = item;
                else
                {
                    if (valoMaximo.sosMayor(item))
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
    }
}