using IComparable;
using PCommand;
using PIterator.Colas;
using PIterator;

namespace IColeccionable.Colas
{
    public class Cola : Coleccionable, Ordenable
    {
        private List<Comparable> elementosCola;
        private byte? tamanioCola = null;
        private OrdenEnAula1 Inicio;
        private OrdenEnAula1 AulaLlena;
        private OrdenEnAula2 LlegaAlumno;

        
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
        public List<Comparable> GetCola { get{ return this.elementosCola;} }
        //Iterador
        public IIterator CrearIterador()
        {
            return new IteradorCola(this);
        }
        //Metodos
        public void Encolar(Comparable elemento) 
        {
            this.elementosCola.Add(elemento);
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
                    if(this.Cuantos() == 0)
                    { 
                        if (Inicio != null)
                            this.Inicio.Ejecutar();
                    }
                    else if(Cuantos() == 39)
                    {
                        if (AulaLlena != null)
                            this.AulaLlena.Ejecutar();
                    }
                    if (LlegaAlumno != null)
                        this.LlegaAlumno.Ejecutar(elemento);
                    
                    elementosCola.Add(elemento);
                }else
                {
                    throw new ColaLLenaException("La cola esta llena.");
                }
            }else 
            {
                if(this.Cuantos() == 0)
                { 
                    if (Inicio != null)
                        this.Inicio.Ejecutar();
                }
                else if(Cuantos() == 39)
                {
                    if (AulaLlena != null)
                        this.AulaLlena.Ejecutar();
                }
                
                if (LlegaAlumno != null)    
                    this.LlegaAlumno.Ejecutar(elemento);
                
                elementosCola.Add(elemento);
            }
        }
        public bool Contiene(Comparable elemento)
        {
            return elementosCola.Contains(elemento);
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
    public class ColaLLenaException : Exception{
        public ColaLLenaException(){}
        public ColaLLenaException(string message) : base(message){}
    };
}