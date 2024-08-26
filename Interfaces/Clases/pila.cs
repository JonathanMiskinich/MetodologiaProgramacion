using System.Collections.Generic;
using Practica1;

namespace Clases.Pila
{
    using System;
    public class Pila<T> : Coleccionable<T>
    {
        private List<T> elementosPila;
        private int? tamanio;
        private int puntero; 

        // Constructores
        public Pila(int tamanioUser)
        {
            this.tamanio = tamanioUser;
            this.elementosPila = new List<T>(tamanioUser);
            this.puntero = 0;
        }

        public Pila()
        {
            this.elementosPila = new List<T>();
            this.puntero = 0;
        }

        // Getters and Setters
        public int getPuntero() { return this.puntero; }
        public int? getTamanio() { return this.tamanio; }

        // Metodos
        public void Apilar(T elemento)
        {
            if (this.tamanio != null)
            {
                if (this.puntero < this.tamanio)
                {
                    elementosPila.Insert(0, elemento);
                    puntero++;
                }else
                {
                    throw new PilaLLenaException();
                }
            }else 
            {
                elementosPila.Insert(0, elemento);
                puntero++;
            }
        }
        public T DesApilar(T elemento)
        {
            T elementoDeLaPila = elementosPila[0];

            this.elementosPila.RemoveAt(0);
            puntero--;

            return elementoDeLaPila;
        }

        public T Top()
        {
            return this.elementosPila[0];
        }
        public bool EsVacia()
        {
            if (this.puntero == 0)
                return true;
            else
                return false;
        }
        public bool EstaLlena()
        {
            if (this.puntero == this.tamanio)
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
            return this.puntero;
        }

        public T Minimo()
        {
            this.elementosPila.Sort();
            return this.elementosPila[0];
        }

        public T Maximo()
        {
            this.elementosPila.Sort();
            return this.elementosPila[elementosPila.Count - 1];
        }
        public void Agregar(Comparable elemento)
        {
            if (this.tamanio != null)
            {
                if (this.puntero < this.tamanio)
                {
                    elementosPila.Insert(0, (T)elemento);
                    puntero++;
                }else
                {
                    throw new PilaLLenaException();
                }
            }else 
            {
                elementosPila.Insert(0, (T)elemento);
                puntero++;
            }
        }
        public bool Contiene(Comparable elemento)
        {
            return elementosPila.Contains((T)elemento);
        }
    }
    public class PilaLLenaException : Exception{
        public PilaLLenaException(){}
        public PilaLLenaException(string message) : base(message){}
    };
}