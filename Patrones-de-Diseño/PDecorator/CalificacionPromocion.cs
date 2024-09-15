using PDecorator.BaseDecorators;
using PDecorator.MostrarCalificacion;
using PDecorator.ConcreteDecorator;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionPromocion : BaseDecorator
    {
        public CalificacionPromocion(IMostrarCalificacion componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            string mensaje = base.MostrarCalificacion();
            int num = FuncionesAuxiliares.UnicoNumeroEnCedena(mensaje);

            if (num >= 7)
                return mensaje + " " + "(PROMOCION)";
            else if (num >= 4 && num < 7)
                return mensaje + " " + "(APROBADO)";
            else
                return mensaje + " " + "(DESAPROBADO)";
        }
    }
}