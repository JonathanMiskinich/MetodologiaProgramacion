using PDecorator.BaseDecorators;
using IAlumnos;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionLegajo : BaseDecorator
    {
        public CalificacionLegajo(IAlumno componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            return $"{alum.getNombre()} ({alum.getLegajo()})\t({alum.getCalificacion()})";
        }
    }
}