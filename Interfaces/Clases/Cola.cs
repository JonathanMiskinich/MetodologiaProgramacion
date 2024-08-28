using System;
using Interfaces_Practica1;

namespace Clases.Cola
{
    public class Cola : Coleccionable
    {
        private List<Comparable> elementosCola;
        private byte? tamanioCola = null;
        
        // Constructor
        public Cola(byte tamanioCola)
        {
            this.tamanioCola = tamanioCola;
            this.elementosCola = new List<Comparable>(tamanioCola);
        }
        public Cola()
        {
            this.elementosCola = new();
        }
        
        //Getters and Setters
        public byte? GetTamanioCola() { return this.tamanioCola; }
        public List<Comparable> GetCola() { return this.elementosCola; }

        //Metodos
        public void Encolar(Comparable elemento) 
        {
            this.elementosCola.Append(elemento);
        }
        public Comparable DesEncolar() 
        {
            Comparable elementoSacar = elementosCola[0];
            elementosCola.RemoveAt(0);
            return elementoSacar; 
        }
        public Comparable Frente() 
        {
            return elementosCola[0];
        }
        public bool EsVacia() 
        {
            return this.elementosCola.Count == 0;
        }
        public bool EstaLlena() 
        {
            return this.elementosCola.Count == this.tamanioCola;
        }
        public byte CantidadElementos() 
        {
            return (byte)this.elementosCola.Count;
        }
        public void Limpiar() 
        {
            this.elementosCola.Clear();
        }

        // Implementacion interfaces
        public int Cuantos()
        {
            return elementosCola.Count;
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
            Comparable valorMaximo = null;
            foreach (Comparable item in this.elementosCola)
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
            if (this.tamanioCola != null)
            {
                if (elementosCola.Count < this.tamanioCola)
                {
                    elementosCola.Add(elemento);
                }else
                {
                    throw new ColaLLenaException("La cola esta llena.");
                }
            }else 
            {
                elementosCola.Add(elemento);
            }
        }
        public bool Contiene(Comparable elemento)
        {
            return elementosCola.Contains(elemento);
        }

    }
    public class ColaLLenaException : Exception{
        public ColaLLenaException(){}
        public ColaLLenaException(string message) : base(message){}
    };
}