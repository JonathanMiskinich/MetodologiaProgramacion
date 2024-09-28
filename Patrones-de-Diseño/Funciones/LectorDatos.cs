namespace Clases.LectorDeDatos
{
    public static class LectorDeDatos
    {
        public static int NumeroPorTeclado()
        {
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public static string StringPorTeclado()
        {
            string mensaje = Console.ReadLine();
            return mensaje;
        }
    }

}