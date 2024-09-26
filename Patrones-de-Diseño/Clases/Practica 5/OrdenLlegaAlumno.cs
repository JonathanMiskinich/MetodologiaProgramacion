using Clases.Aulas;
using Interfaces_Practica1;
using Interfaz.IAlumnos;

namespace PCommand
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        private Aula _aula;
        public OrdenLlegaAlumno(Aula aula)
        {
            this._aula = aula;
        }
        public void Ejecutar(Comparable c)
        {
            if (c is IAlumno alumno)
                this._aula.NuevoAlumno(alumno);
        }
    }
}