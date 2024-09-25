using Interfaces_Practica1;
using Interfaces.PStrategy_Comparacion;

namespace Interfaz.IAlumnos
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