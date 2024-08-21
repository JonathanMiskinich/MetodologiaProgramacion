using Practica1;

namespace Clases.Practica_1
{
    public class Numero : Comparable
    {
        private sbyte valor;

        public Numero(sbyte num)
        {
            this.valor = num;
        }

        public bool sosIgual(Comparable otro)
        {
            if (otro is Numero number)
            {
                number = (Numero)otro;
                return number.VALOR == this.valor;
            }
            return false;
        }

        public bool sosMenor(Comparable otro)
        {
            if (otro is Numero)
            {
                Numero num = (Numero)otro;
                return (num.VALOR < this.valor);
            }
            return false;
        }

        public bool sosMayor(Comparable otro)
        {
            if (otro is Numero)
            {
                Numero num = (Numero)otro;
                return num.VALOR < this.valor;
            }
            return false;
        }
        
        public sbyte VALOR
        {
            get
            {
                return this.valor;
            }
            set 
            {
                this.valor = value;
            }
        }
    }
}