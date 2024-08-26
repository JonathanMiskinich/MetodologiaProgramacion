/*Impletación de diferentes interfaces de la práctica 1*/
namespace Interfaces_Practica1
{
    public interface Comparable
    {
        public bool sosIgual(Comparable comparacion);
        public bool sosMenor(Comparable comparacion);
        public bool sosMayor(Comparable comparacion);

    }

    public interface Coleccionable<T>
    {
        public int Cuantos();
        public T Minimo();
        public T Maximo();
        public void Agregar(Comparable elemento);
        public bool Contiene(Comparable elemento);
    }
}