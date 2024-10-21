
namespace ObtencionDeDatos
{
    public class GeneradorDatosAzar : BaseManejadorDatos
    {
        public override int ObtenerNumero(int max)
        {
            return new Random().Next(0, max);
        }

        public override string ObtenerCadena(int cant)
        {
            string mensaje = "";
            for (int i = 0; i < cant; i++)
            {
                char codigoAsciiLetra = (char)new Random().Next(97, 123);
                mensaje += codigoAsciiLetra;
            }
            return mensaje;
        }
    }
}