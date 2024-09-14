namespace PIterator
{
    public interface IIterator
    {
        void Primero();
        void Siguiente();
        bool Fin();
        object Actual();
    }
}