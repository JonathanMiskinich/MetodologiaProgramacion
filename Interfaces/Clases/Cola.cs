using System;
using Interfaces_Practica1;

namespace Cola
{
    public class Cola<T> : Coleccionable<T>
    {
        private List<T> elementosCola;
        private byte tamanioCola;
        
        // Constructor
        public Cola(byte tamanioCola)
        {
            this.tamanioCola = tamanioCola;
            this.elementosCola = new List<T>(tamanioCola);
        }
        public Cola()
        {
            this.elementosCola = new();
        }
        
        //Getters and Setters
        public byte GetTamanioCola() { return this.tamanioCola; }
        public List<T> GetCola() { return this.elementosCola; }

        //Metodos
        public void Encolar(T elemento) 
        {
            this.elementosCola.Append(elemento);
        }
        public T DesEncolar() 
        {
            T elementoSacar = elementosCola[elementosCola.Count - 1];
            elementosCola.RemoveAt(elementosCola.Count - 1);
            return elementoSacar; 
        }
        public T Frente() {}
        public bool EsVacia() {}
        public bool EstaLlena() {}
        public byte CantidadElementos() {}
        public void Limpiar() {}

    }
}