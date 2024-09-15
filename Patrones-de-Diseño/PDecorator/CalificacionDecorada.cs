using PDecorator.BaseDecorators;
using PDecorator.MostrarCalificacion;
using PDecorator.ConcreteDecorator;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionDecorada : BaseDecorator
    {
        public CalificacionDecorada(IMostrarCalificacion componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            string mensaje = base.MostrarCalificacion();
            const int espacios = 2;
            string asteriscos = new string('*', mensaje.Length + (espacios + 2)* 2);
            string espaciosString = new string(' ', espacios);
            
            mensaje = asteriscos + "\n*" + $"{espaciosString}" + mensaje + $"{espaciosString}" + "*\n" + asteriscos;
            return mensaje;
        }
    }
}