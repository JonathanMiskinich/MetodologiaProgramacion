using IComparable;
using Alumnos.Comparaciones;

namespace IAlumnos
{
    public interface IAlumno : Comparable
    {
        int getLegajo();
        string getNombre();
        int getCalificacion();
        void setCalificacion(int calif);
        float getPromedio();
        string MostrarCalificacion();
        int ResponderPregunta(int pregunta);
        int getDni();
        void setMetodoComparar(Comparacion comparar);
    }
}