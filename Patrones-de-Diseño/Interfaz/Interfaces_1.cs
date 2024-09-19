/*Impletación de diferentes interfaces de la práctica 1*/
using PIterator;
namespace Interfaces_Practica1
{
    public interface Comparable
    {
        bool sosIgual(Comparable comparacion);
        bool sosMenor(Comparable comparacion);
        bool sosMayor(Comparable comparacion);

    }

    public interface Coleccionable
    {
        IIterator CrearIterador();
        public int Cuantos();
        public Comparable Minimo();
        public Comparable Maximo();
        public void Agregar(Comparable elemento);
        public bool Contiene(Comparable elemento);
    }
}