using IComparable;

namespace Clases.Clave_Valor
{
    public class ClaveValor
    {
        private Comparable clave;
        private object value;

        // Constructor
        public ClaveValor(Comparable clave, object valor)
        {
            this.clave = clave;
            this.value = valor;
        }

        // Getters and Setters
        public Comparable getClave
        {
            get { return this.clave; }
        }
        public object getValue
        {
            get { return this.value; }
        }
        public void setValue(object valor)
        {
            this.value = valor;
        }

        // Metodos de la interfaz
        public bool sosIgual(Comparable claveUser)
        {
            if (claveUser is Comparable)
                return claveUser.sosIgual(this.clave);
            return false;
        }
        
        public override string ToString()
        {
            return $"Clave: {this.clave}\nValor: {this.value}";
        }
    }
}