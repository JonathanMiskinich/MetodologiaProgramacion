using PDecorator.BaseDecorators;
using IAlumnos;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionPromocion : BaseDecorator
    {
        public CalificacionPromocion(IAlumno componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            string mensaje = base.MostrarCalificacion();
            int num = base.getCalificacion();

            if (num >= 7)
                return mensaje + " " + "(PROMOCION)";
            else if (num >= 4 && num < 7)
                return mensaje + " " + "(APROBADO)";
            else
                return mensaje + " " + "(DESAPROBADO)";
        }
    }
}