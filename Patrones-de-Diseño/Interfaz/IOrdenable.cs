using IComparable;

namespace PCommand
{
    public interface Ordenable
    {
        void SetOrdenInicio(OrdenEnAula1 orden);
        void SetOrdenLlegaAlumno(OrdenEnAula2 orden);
        void SetOrdenAulaLlena(OrdenEnAula1 orden);

    }

    public interface OrdenEnAula1
    {
        void Ejecutar();
    }

    public interface OrdenEnAula2
    {
        void Ejecutar(Comparable c);
    }
}