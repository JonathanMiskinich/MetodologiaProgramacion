using Interfaces_Practica1;
using PFactoryMethod.CreadorComparables;
using Clases.DatosAzar;
using Clases.LectorDeDatos;
using Funciones;
using Clases.Numero;

namespace PFactoryMethod.CreadorNumero
{
    public class CreadorNumero : ICreadorComparable
    {
        public Comparable CrearAleatorio()
        {
            return new Numero((sbyte)GeneradorDatosAzar.NumeroAleatorio(128));
        }

        public Comparable CrearPorTeclado()
        {
            return new Numero((sbyte)LectorDeDatos.NumeroPorTeclado());
        }
    }
}