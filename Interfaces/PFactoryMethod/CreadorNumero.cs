using PCreadorComparables;
using Clases.Numero;
using Clases.DatosAzar;
using Interfaces_Practica1;

namespace PCreadorNumero
{
    public class CreadorNumero : ComparableFactory
    {
        public override Comparable CreadorComparable()
        {
            return new Numero((sbyte)GeneradorDatosAzar.NumeroAleatorio(128));
        }
    }
}