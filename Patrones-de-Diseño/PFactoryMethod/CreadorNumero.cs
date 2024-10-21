using IComparable;
using PFactoryMethod.CreadorComparables;
using ObtencionDeDatos;
using Funciones;
using IComparable.Numero;

namespace PFactoryMethod.CreadorNumero
{
    public class CreadorNumero : ICreadorComparable
    {
        protected IObtenerDatos dato;
        public Comparable CrearAleatorio(string opcion)
        {
            dato = (GeneradorDatosAzar)dato;
            return new Numero((sbyte)dato.ObtenerNumero(128));
        }

        public Comparable CrearPorArchivo(string opcion)
        {
            dato = (LectorDeArchivos)dato;
            dato.SetManejador(new GeneradorDatosAzar());
            return new Numero((sbyte)dato.ObtenerNumero(128));
        }

        public Comparable CrearPorTeclado(string opcion)
        {
            dato = (LectorDeDatos)dato;
            dato.SetManejador(new GeneradorDatosAzar());
            return new Numero((sbyte)dato.ObtenerNumero(128));
        }
    }
}