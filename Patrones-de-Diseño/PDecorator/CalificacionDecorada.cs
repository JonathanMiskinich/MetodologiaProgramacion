using PDecorator.BaseDecorators;
using Interfaz.IAlumnos;
using PDecorator.ConcreteDecorator;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionDecorada : BaseDecorator
    {
        public CalificacionDecorada(IAlumno componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            string mensaje = base.MostrarCalificacion();
            const int espacios = 2;
            string asteriscos = new('*', mensaje.Length + (espacios + 2)* 2);
            string espaciosString = new(' ', espacios);
            
            mensaje = asteriscos + "\n*" + $"{espaciosString}" + mensaje + $"{espaciosString}" + "*\n" + asteriscos;
            return mensaje;
        }
    }
}