using PDecorator.BaseDecorators;
using PDecorator.MostrarCalificacion;

namespace PDecorator.ConcreteDecorator
{
    public class CalificacionLetra : BaseDecorator
    {
        public CalificacionLetra(IMostrarCalificacion componente) : base(componente){}
        public override string MostrarCalificacion()
        {
            string mensaje = base.MostrarCalificacion();
            char caracter = (char)(FuncionesAuxiliares.UnicoNumeroEnCedena(mensaje) + '0');
            string textoAgregar = FuncionesAuxiliares.NumeroALetra(caracter);

            return mensaje + " " + $"({textoAgregar})";
        }
    }
    public class FuncionesAuxiliares
    {
        public static string NumeroALetra(char numeroEnTexto)
        {
            List<string> numerosEnLetras = new List<string>
            {
                "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"
            };
            List<int> numeros = new List<int> {0,1,2,3,4,5,6,7,8,9,10};
            int num = numeroEnTexto - '0';
            
            if (numeros.Contains(num))
            {
                return numerosEnLetras[num];
            }
            return "";
        }

        public static int UnicoNumeroEnCedena(string mensaje)
        {
            string[] partesDeLaCadena = mensaje.Split(new[] { ' ', '\t' });
            foreach (string cadena in partesDeLaCadena)
            {
                if (cadena.Length == 1)
                    return cadena[0] - '0';   
            }
            return -1;
        }
    }
}