using PDecorator.MostrarCalificacion;

namespace PDecorator.BaseDecorators
{
    public class BaseDecorator
    {
        protected IMostrarCalificacion decorador;
        public BaseDecorator(IMostrarCalificacion componente)
        {
            this.decorador = componente;
        }
        public IMostrarCalificacion getDecorador
        {
            get { return this.decorador; }
        }
        public virtual string MostrarCalificacion()
        {
            return decorador.MostrarCalificacion();
        }
    }
}