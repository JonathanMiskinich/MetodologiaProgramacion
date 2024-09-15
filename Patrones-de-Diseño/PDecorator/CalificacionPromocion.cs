using PDecorator.BaseDecorators;
using PDecorator.MostrarCalificacion;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionPromocion : BaseDecorator
    {
        public CalificacionPromocion(IMostrarCalificacion componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            string mensaje = base.MostrarCalificacion();
            int calificacion = mensaje[mensaje.Length -1] - '0';

            if (calificacion >= 7)
                return mensaje + " " + "(PROMOCION)";
            else if (calificacion >= 4 && calificacion < 7)
                return mensaje + " " + "(APROBADO)";
            else
                return mensaje + " " + "(DESAPROBADO)";
        }
    }
}