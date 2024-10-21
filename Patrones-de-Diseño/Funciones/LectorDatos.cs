namespace ObtencionDeDatos
{
    public class LectorDeDatos : BaseManejadorDatos
    {
        public override int ObtenerNumero(int max)
        {
            string datoUser  = Console.ReadLine();

            if (int.TryParse(datoUser, out int num))
                return num;
            else if (siguienteManejador != null)
            {
                return siguienteManejador.ObtenerNumero(max);
            }
            else
            {
                throw new FormatException("No se pudo devolver un numero.");
            }
        }

        public override string ObtenerCadena(int cant)
        {
            string mensaje = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(mensaje))
            {
                return mensaje;
            }
            else if (siguienteManejador !=  null)
            {
                return siguienteManejador.ObtenerCadena(cant);
            }
            else
            {
                throw new Exception("No se pudo devolver una cadena de texto.");
            }
        }
    }

}