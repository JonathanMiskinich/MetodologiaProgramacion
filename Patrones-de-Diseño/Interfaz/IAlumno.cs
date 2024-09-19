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
        bool sosIgual(IAlumno comparacion);
        bool sosMenor(IAlumno comparacion);
        bool sosMayor(IAlumno comparacion);
        void setMetodoComparar(Comparacion comparar);
    }
}