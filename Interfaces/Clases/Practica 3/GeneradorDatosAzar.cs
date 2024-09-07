namespace Clases.DatosAzar
{
    public static class GeneradorDatosAzar
    {
        public static int NumeroAleatorio(int max)
        {
            return new Random().Next(0, max);
        }
        public static string StringAleatorio(int cant)
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