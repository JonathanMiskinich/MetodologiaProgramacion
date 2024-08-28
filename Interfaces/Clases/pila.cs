using System.Collections.Generic;
using Interfaces_Practica1;

namespace Clases.Pila
{
    using System;
    public class Pila : Coleccionable
    {
        private List<Comparable> elementosPila;
        private int? tamanio; 

        // Constructores
        public Pila(int tamanioUser)
        {
            this.tamanio = tamanioUser;
            this.elementosPila = new List<Comparable>(tamanioUser);
        }

        public Pila()
        {
            this.elementosPila = new List<Comparable>();
            this.tamanio = null;
        }

        // Getters and Setters
        public int? getTamanio() { return this.tamanio; }

        // Metodos
        public void Apilar(Comparable elemento)
        {
            if (this.tamanio != null)
            {
                if (elementosPila.Count < this.tamanio)
                {
                    elementosPila.Add(elemento);
                }else
                {
                    throw new PilaLLenaException();
                }
            }else 
            {
                elementosPila.Insert(0, elemento);
            }
        }
        public Comparable DesApilar()
        {
            Comparable elementoDeLaPila = elementosPila[elementosPila.Count - 1];

            this.elementosPila.RemoveAt(elementosPila.Count - 1);

            return elementoDeLaPila;
        }

        public Comparable Top()
        {
            return this.elementosPila[elementosPila.Count - 1];
        }
        public bool EsVacia()
        {
            if (elementosPila.Count == 0)
                return true;
            else
                return false;
        }
        public bool EstaLlena()
        {
            if (elementosPila.Count == this.tamanio)
                return true;
            else
                return false;
        }
        public void Limpiar()
        {
            elementosPila.RemoveRange(0, elementosPila.Count);
        }

        // metodos Coleccionable
        public int Cuantos()
        {
            return this.elementosPila.Count;
        }

        public Comparable Minimo()
        {
            List<Comparable> lista = new List<Comparable>(elementosPila);
            lista.Sort();
            return lista[0];
        }

        public Comparable Maximo()
        {
            List<Comparable> lista = new List<Comparable>(elementosPila);
            lista.Sort();
            return lista[lista.Count - 1];
        }
        public void Agregar(Comparable elemento)
        {
            if (this.tamanio != null)
            {
                if (elementosPila.Count < this.tamanio)
                {
                    elementosPila.Add(elemento);
                }else
                {
                    throw new PilaLLenaException();
                }
            }else 
            {
                elementosPila.Add(elemento);
            }
        }
        public bool Contiene(Comparable elemento)
        {
            return elementosPila.Contains(elemento);
        }
    }
    public class PilaLLenaException : Exception{
        public PilaLLenaException(){}
        public PilaLLenaException(string message) : base(message){}
    }
}