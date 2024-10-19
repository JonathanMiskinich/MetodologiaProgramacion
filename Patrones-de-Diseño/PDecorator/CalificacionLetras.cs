using PDecorator.BaseDecorators;
using IAlumnos;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionLetra : BaseDecorator
    {
        public CalificacionLetra(IAlumno componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            string mensaje = base.MostrarCalificacion();
            string textoAgregar = FuncionesAuxiliares.NumeroALetra(base.getCalificacion());

            return mensaje + " " + $"({textoAgregar})";
        }
    }
    public class FuncionesAuxiliares
    {
        public static string NumeroALetra(int numero)
        {
            List<string> numerosEnLetras = new List<string>
            {
                "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"
            };
            List<int> numeros = new List<int> {0,1,2,3,4,5,6,7,8,9,10};
            
            if (numeros.Contains(numero))
            {
                return numerosEnLetras[numero];
            }
            return "";
        }
    }
}