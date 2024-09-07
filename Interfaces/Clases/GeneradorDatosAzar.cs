namespace Clases.DatosAzar
{
    public static class GeneradorDatosAzar
    {
        public static int NumeroAleatorio(int max)
        {
            return new Random().Next(0, max);
        }
    }
}